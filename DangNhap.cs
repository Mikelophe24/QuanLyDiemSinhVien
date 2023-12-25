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
    public partial class DangNhap : Form
    {
        private const string Connectring = "Data Source=MIKE2406\\MSSQLSERVER03;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(taikhoan)  || string.IsNullOrEmpty(matkhau) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập  " , " Lỗi ");
                return;
            }    
            if ( checkLogoin( taikhoan , matkhau ) )
            {
                MessageBox.Show(" Đăng nhập thành công ", " Thông Báo", MessageBoxButtons.OK);
                FormTong formTong = new FormTong();
                formTong.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Đăng nhập không thành công , vui lòng kiểm tra tên đăng nhập và tài khoản ", " Thông Báo ", MessageBoxButtons.OKCancel);
            }
        }
        private bool checkLogoin( string taikhoan , string matkhau )
        {
            using ( SqlConnection conn = new SqlConnection(Connectring))
            {
                try
                {
                    conn.Open();

                    string Kiemtra = " SELECT * FROM DangNhap WHERE taikhoan = @taikhoan AND matkhau = @matkhau ";
                    using ( SqlCommand cmd = new SqlCommand( Kiemtra , conn))
                    {
                        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                        cmd.Parameters.AddWithValue("@matkhau", matkhau);

                     object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            if (int.TryParse(result.ToString() , out int count))
                            {
                                return count > 0;
                            }    
                        }
                        else { return false; }
                    }
                    
                }
                catch ( Exception ex )
                {
                    MessageBox.Show("lỗi kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi ", MessageBoxButtons.OK);
                    return false;

                } 

            }
            return false;
        }

    }
}
