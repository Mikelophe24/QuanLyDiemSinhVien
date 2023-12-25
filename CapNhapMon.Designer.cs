namespace QuanLyDiemSinhVien
{
    partial class CapNhapMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSoLanHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSoTienChi = new System.Windows.Forms.ComboBox();
            this.txtTenHocPhan = new System.Windows.Forms.TextBox();
            this.txtMaHocPhan = new System.Windows.Forms.TextBox();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCapNhapMon = new System.Windows.Forms.DataGridView();
            this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solanhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhapMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhập môn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học phần : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiến chỉ : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên học phần : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbSoLanHoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbSoTienChi);
            this.groupBox1.Controls.Add(this.txtTenHocPhan);
            this.groupBox1.Controls.Add(this.txtMaHocPhan);
            this.groupBox1.Controls.Add(this.txtTenSinhVien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhập môn ";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(461, 151);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(148, 38);
            this.btnCapNhap.TabIndex = 17;
            this.btnCapNhap.Text = "Cập nhập ";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 16;
            // 
            // cbSoLanHoc
            // 
            this.cbSoLanHoc.FormattingEnabled = true;
            this.cbSoLanHoc.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSoLanHoc.Location = new System.Drawing.Point(189, 143);
            this.cbSoLanHoc.Name = "cbSoLanHoc";
            this.cbSoLanHoc.Size = new System.Drawing.Size(137, 32);
            this.cbSoLanHoc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số lần học :";
            // 
            // cbSoTienChi
            // 
            this.cbSoTienChi.FormattingEnabled = true;
            this.cbSoTienChi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSoTienChi.Location = new System.Drawing.Point(621, 83);
            this.cbSoTienChi.Name = "cbSoTienChi";
            this.cbSoTienChi.Size = new System.Drawing.Size(137, 32);
            this.cbSoTienChi.TabIndex = 13;
            // 
            // txtTenHocPhan
            // 
            this.txtTenHocPhan.Location = new System.Drawing.Point(189, 86);
            this.txtTenHocPhan.Multiline = true;
            this.txtTenHocPhan.Name = "txtTenHocPhan";
            this.txtTenHocPhan.Size = new System.Drawing.Size(252, 38);
            this.txtTenHocPhan.TabIndex = 12;
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Location = new System.Drawing.Point(621, 21);
            this.txtMaHocPhan.Multiline = true;
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.Size = new System.Drawing.Size(252, 38);
            this.txtMaHocPhan.TabIndex = 11;
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(189, 21);
            this.txtTenSinhVien.Multiline = true;
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(252, 38);
            this.txtTenSinhVien.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên sinh viên : ";
            // 
            // dgvCapNhapMon
            // 
            this.dgvCapNhapMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhapMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensinhvien,
            this.mahocphan,
            this.tenhocphan,
            this.sotienchi,
            this.solanhoc});
            this.dgvCapNhapMon.Location = new System.Drawing.Point(44, 317);
            this.dgvCapNhapMon.Name = "dgvCapNhapMon";
            this.dgvCapNhapMon.Size = new System.Drawing.Size(942, 231);
            this.dgvCapNhapMon.TabIndex = 7;
            this.dgvCapNhapMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapNhapMon_CellContentClick);
            // 
            // tensinhvien
            // 
            this.tensinhvien.DataPropertyName = "tensinhvien";
            this.tensinhvien.HeaderText = "Tên Sinh Viên";
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.Width = 220;
            // 
            // mahocphan
            // 
            this.mahocphan.DataPropertyName = "mahocphan";
            this.mahocphan.HeaderText = "Mã Học Phần";
            this.mahocphan.Name = "mahocphan";
            this.mahocphan.Width = 260;
            // 
            // tenhocphan
            // 
            this.tenhocphan.DataPropertyName = "tenhocphan";
            this.tenhocphan.HeaderText = "Tên Học Phần";
            this.tenhocphan.Name = "tenhocphan";
            this.tenhocphan.Width = 200;
            // 
            // sotienchi
            // 
            this.sotienchi.DataPropertyName = "sotienchi";
            this.sotienchi.HeaderText = "Số tiến chỉ";
            this.sotienchi.Name = "sotienchi";
            // 
            // solanhoc
            // 
            this.solanhoc.DataPropertyName = "solanhoc";
            this.solanhoc.HeaderText = "Số Lần Học";
            this.solanhoc.Name = "solanhoc";
            this.solanhoc.Width = 120;
            // 
            // CapNhapMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 645);
            this.Controls.Add(this.dgvCapNhapMon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "CapNhapMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhapMon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CapNhapMon_FormClosed);
            this.Load += new System.EventHandler(this.CapNhapMon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhapMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.TextBox txtTenHocPhan;
        private System.Windows.Forms.TextBox txtMaHocPhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSoLanHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSoTienChi;
        private System.Windows.Forms.DataGridView dgvCapNhapMon;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn solanhoc;
    }
}