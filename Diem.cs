using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class Diem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MIKE2406\\MSSQLSERVER03;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True");

        public Diem()
        {
            InitializeComponent();
        }
        private void load_dgvDiem()
        {

            con.Open();


            SqlCommand cmd = new SqlCommand(" SELECT * FROM DiemSinhVien ", con);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable tb = new DataTable();
            ad.Fill(tb);
            cmd.Dispose();
            con.Close();
            dgvDiem.DataSource = tb;
            dgvDiem.Refresh();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string p_tensinhvien = txtTenSinhVien.Text.Trim();
                string p_masinhvien = txtMaSinhVien.Text.Trim();
                string p_mahocphan = txtMaHocPhan.Text.Trim();
                string p_tenhocphan = txtTenHocPhan.Text.Trim();
                int p_diemchuyencan, p_kiemtragiuaki, p_thuchanh, p_thiketthuc, p_thaoluan, p_tongkethocphan;
                string p_diemchu = txtDiemChu.Text.Trim();
                string p_danhgia = cbDanhGia.SelectedText.Trim();

                // Kiểm tra và chuyển đổi các giá trị điểm từ chuỗi sang kiểu INT
                if (int.TryParse(txtDiemChuyenCan.Text.Trim(), out p_diemchuyencan) &&
                    int.TryParse(txtKiemTraGiuKi.Text.Trim(), out p_kiemtragiuaki) &&
                    int.TryParse(txtThucHanh.Text.Trim(), out p_thuchanh) &&
                    int.TryParse(txtThiKetThuc.Text.Trim(), out p_thiketthuc) &&
                    int.TryParse(txtThaoLuon.Text.Trim(), out p_thaoluan) &&
                    int.TryParse(txtTongKet.Text.Trim(), out p_tongkethocphan))
                {
                    con.Open();

                    string sql = "INSERT INTO DiemSinhVien VALUES (@tensinhvien, @masinhvien, @mahocphan, @tenhocphan, @diemchuyencan, @kiemtragiuaki, @thuchanh, @thiketthuc, @thaoluan, @tongkethocphan, @diemchu, @danhgia)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.Add("@tensinhvien", SqlDbType.VarChar, 50).Value = p_tensinhvien;
                    cmd.Parameters.Add("@masinhvien", SqlDbType.VarChar, 50).Value = p_masinhvien;
                    cmd.Parameters.Add("@mahocphan", SqlDbType.VarChar, 50).Value = p_mahocphan;
                    cmd.Parameters.Add("@tenhocphan", SqlDbType.VarChar, 50).Value = p_tenhocphan;
                    cmd.Parameters.Add("@diemchuyencan", SqlDbType.Int).Value = p_diemchuyencan;
                    cmd.Parameters.Add("@kiemtragiuaki", SqlDbType.Int).Value = p_kiemtragiuaki;
                    cmd.Parameters.Add("@thuchanh", SqlDbType.Int).Value = p_thuchanh;
                    cmd.Parameters.Add("@thiketthuc", SqlDbType.Int).Value = p_thiketthuc;
                    cmd.Parameters.Add("@thaoluan", SqlDbType.Int).Value = p_thaoluan;
                    cmd.Parameters.Add("@tongkethocphan", SqlDbType.Int).Value = p_tongkethocphan;
                    cmd.Parameters.Add("@diemchu", SqlDbType.VarChar, 50).Value = p_diemchu;
                    cmd.Parameters.Add("@danhgia", SqlDbType.VarChar, 50).Value = p_danhgia;

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Cập nhật thành công");
                    load_dgvDiem();
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ. Vui lòng kiểm tra lại các điểm số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtTenSinhVien.Text = dgvDiem.Rows[i].Cells[0].Value.ToString();
            txtMaSinhVien.Text = dgvDiem.Rows[i].Cells[1].Value.ToString();
            txtMaHocPhan.Text = dgvDiem.Rows[i].Cells[2].Value.ToString();
            txtTenHocPhan.Text = dgvDiem.Rows[i].Cells[3].Value.ToString();
            txtDiemChuyenCan.Text = dgvDiem.Rows[i].Cells[4].Value.ToString();
            txtKiemTraGiuKi.Text = dgvDiem.Rows[i].Cells[5].Value.ToString();
            txtThucHanh.Text = dgvDiem.Rows[i].Cells[6].Value.ToString();
            txtThiKetThuc.Text = dgvDiem.Rows[i].Cells[7].Value.ToString();
            txtThaoLuon.Text = dgvDiem.Rows[i].Cells[8].Value.ToString();
            txtTongKet.Text = dgvDiem.Rows[i].Cells[9].Value.ToString();
            txtDiemChu.Text = dgvDiem.Rows[i].Cells[10].Value.ToString();
            cbDanhGia.Text = dgvDiem.Rows[i].Cells[11].Value.ToString();

        }

        private void Diem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTong formTong = new FormTong();
            formTong.ShowDialog();
        }
    }
}
