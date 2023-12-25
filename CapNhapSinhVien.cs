using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDiemSinhVien
{
    public partial class CapNhapSinhVien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MIKE2406\\MSSQLSERVER03;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True");
        public CapNhapSinhVien()
        {
            InitializeComponent();
        }
        private void load_dgvCapNhapSinhVien()
        {
            
                con.Open();
           
            SqlCommand cmd = new SqlCommand(" SELECT * FROM CapNhap ", con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable tb = new DataTable();
            ad.Fill(tb);
            cmd.Dispose();
            con.Close();
            dgvCapNhapSinhVien.DataSource = tb;
            dgvCapNhapSinhVien.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string p_hoten = txtHoTen.Text.Trim();
            string p_khoa = cbKhoa.Text.Trim();
            string p_trangthai = cbTrangThai.Text.Trim();
            string p_masinhvien = txtMaSinhVien.Text.Trim();
            string p_lop = txtLop.Text.Trim();
            string p_quequan = txtQueQuan.Text.Trim();
           

           
             con.Open();
            
            string sql = " INSERT CapNhap Values ( @hoten , @khoa, @trangthai , @masinhvien , @lop , @quequan)";
            SqlCommand cmd = new SqlCommand (sql, con);
            cmd.Parameters.Add("@hoten ", SqlDbType.VarChar,50).Value = p_hoten;
            cmd.Parameters.Add("@khoa ", SqlDbType.VarChar, 50).Value = p_khoa;
            cmd.Parameters.Add("@trangthai ", SqlDbType.VarChar, 50).Value = p_trangthai;
            cmd.Parameters.Add("@masinhvien ", SqlDbType.VarChar, 50).Value = p_masinhvien;
            cmd.Parameters.Add("@lop ", SqlDbType.VarChar, 50).Value = p_lop;
            cmd.Parameters.Add("@quequan ", SqlDbType.VarChar, 50).Value = p_quequan;
            
            cmd.ExecuteNonQuery();
            cmd.Dispose ();
            con.Close ();
            MessageBox.Show(" Cập nhập thành công ");
            load_dgvCapNhapSinhVien();
        


        }

        private void dgvCapNhapSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtHoTen.Text = dgvCapNhapSinhVien.Rows[i].Cells[0].Value.ToString();
            cbKhoa.Text = dgvCapNhapSinhVien.Rows[i].Cells[1].Value.ToString();
            cbTrangThai.Text = dgvCapNhapSinhVien.Rows[i].Cells[2].Value.ToString();
            txtMaSinhVien.Text = dgvCapNhapSinhVien.Rows[i].Cells[3].Value.ToString();
            txtLop.Text = dgvCapNhapSinhVien.Rows[i].Cells[4].Value.ToString();
            txtQueQuan.Text = dgvCapNhapSinhVien.Rows[i].Cells[5].Value.ToString();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string p_hoten = txtHoTen.Text.Trim();
            string p_masinhvien = txtMaSinhVien.Text.Trim();

            con.Open();

            string sql = " SELECT * FROM CapNhap WHERE hoten = N '" + p_hoten + "' OR masinhvien = N '" + p_masinhvien + "'  ";
            SqlCommand cmd = new SqlCommand( sql, con );
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            dgvCapNhapSinhVien.DataSource = dt;
            dgvCapNhapSinhVien.Refresh();
        }

        private void CapNhapSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void CapNhapSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTong formTong = new FormTong();
            formTong.ShowDialog();
        }
    }
}
