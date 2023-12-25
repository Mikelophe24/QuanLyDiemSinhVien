using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyDiemSinhVien
{

    public partial class CapNhapMon : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MIKE2406\\MSSQLSERVER03;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True");

        public CapNhapMon()
        {
            InitializeComponent();
        }

        private void load_dgvCapNhapMon()
        {
            
            con.Open();
            

            SqlCommand cmd = new SqlCommand(" SELECT * FROM CapNhapMon ", con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable tb = new DataTable();
            ad.Fill(tb);
            cmd.Dispose();
            con.Close();
            dgvCapNhapMon.DataSource = tb;
            dgvCapNhapMon.Refresh();
        }

        private void CapNhapMon_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string p_tensinhvien = txtTenSinhVien.Text.Trim();
            string p_mahocphan = txtMaHocPhan.Text.Trim();
            string p_tenhocphan = txtTenHocPhan.Text.Trim();
            string p_sotinchi = cbSoTienChi.SelectedIndex.ToString();
            string p_solanhoc = cbSoLanHoc.SelectedIndex.ToString();

            con.Open();
            

            string sql = " INSERT CapNhapMon Values ( @tensinhvien , @mahocphan , @tenhocphan , @sotinchi , @solanhoc)";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.Add("@tensinhvien ", SqlDbType.VarChar, 50).Value = p_tensinhvien;
            cmd.Parameters.Add("@mahocphan ", SqlDbType.VarChar, 50).Value = p_mahocphan;
            cmd.Parameters.Add("@tenhocphan ", SqlDbType.VarChar, 50).Value = p_tenhocphan;
            cmd.Parameters.Add("@sotinchi ", SqlDbType.Int).Value = p_sotinchi;
            cmd.Parameters.Add("@solanhoc ", SqlDbType.Int).Value = p_solanhoc;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show(" Cập nhập thành công ");
            load_dgvCapNhapMon();


        }

        private void dgvCapNhapMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtTenSinhVien.Text = dgvCapNhapMon.Rows[i].Cells[0].Value.ToString();
            txtMaHocPhan.Text = dgvCapNhapMon.Rows[i].Cells[1].Value.ToString();
            txtTenHocPhan.Text = dgvCapNhapMon.Rows[i].Cells[2].Value.ToString();
            cbSoTienChi.Text = dgvCapNhapMon.Rows[i].Cells[3].Value.ToString();
            cbSoLanHoc.Text = dgvCapNhapMon.Rows[i].Cells[4].Value.ToString();
        }

        private void CapNhapMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTong formTong = new FormTong();
            formTong.ShowDialog();
        }
    }
}
