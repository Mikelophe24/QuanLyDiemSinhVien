using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class FormTong : Form
    {
        public FormTong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapNhapSinhVien capNhapSinhVien = new CapNhapSinhVien();
            capNhapSinhVien.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapNhapMon capNhapMon = new CapNhapMon();
            capNhapMon.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            diem.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DiemTrungBinh diemTrungBinh = new DiemTrungBinh();
            diemTrungBinh.ShowDialog();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HOcBongXuatXac hOcBongXuatXac  = new HOcBongXuatXac();
            hOcBongXuatXac.ShowDialog();
            this.Hide();

        }
    }
}
