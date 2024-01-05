namespace OnTap1
{
    partial class Form1
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_ChamSocHo = new System.Windows.Forms.RadioButton();
            this.rad_ChuaBenh = new System.Windows.Forms.RadioButton();
            this.dtp_NgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_NgayNhan = new System.Windows.Forms.Label();
            this.txt_CPT_NCS = new System.Windows.Forms.TextBox();
            this.lbl_CPT_NCS = new System.Windows.Forms.Label();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.lbl_TinhTrang = new System.Windows.Forms.Label();
            this.txt_CanNang = new System.Windows.Forms.TextBox();
            this.lbl_CanNang = new System.Windows.Forms.Label();
            this.txt_ChungLoai = new System.Windows.Forms.TextBox();
            this.lbl_ChungLoai = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.txt_MaDon = new System.Windows.Forms.TextBox();
            this.lbl_MaDon = new System.Windows.Forms.Label();
            this.grp_DanhSachThuCung = new System.Windows.Forms.GroupBox();
            this.lv_DanhSachThuCung = new System.Windows.Forms.ListView();
            this.col_MaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ChungLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_TacVu = new System.Windows.Forms.GroupBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_SapXep = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grp_ThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_DanhSachThuCung.SuspendLayout();
            this.grp_TacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(62, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(823, 29);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CHƯƠNG TRÌNH QUẢN LÝ DOANH THU DỊCH VỤ CHĂM SÓC THÚ CƯNG";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.Controls.Add(this.panel1);
            this.grp_ThongTin.Controls.Add(this.dtp_NgayNhan);
            this.grp_ThongTin.Controls.Add(this.label8);
            this.grp_ThongTin.Controls.Add(this.lbl_NgayNhan);
            this.grp_ThongTin.Controls.Add(this.txt_CPT_NCS);
            this.grp_ThongTin.Controls.Add(this.lbl_CPT_NCS);
            this.grp_ThongTin.Controls.Add(this.txt_TinhTrang);
            this.grp_ThongTin.Controls.Add(this.lbl_TinhTrang);
            this.grp_ThongTin.Controls.Add(this.txt_CanNang);
            this.grp_ThongTin.Controls.Add(this.lbl_CanNang);
            this.grp_ThongTin.Controls.Add(this.txt_ChungLoai);
            this.grp_ThongTin.Controls.Add(this.lbl_ChungLoai);
            this.grp_ThongTin.Controls.Add(this.txt_Ten);
            this.grp_ThongTin.Controls.Add(this.lbl_Ten);
            this.grp_ThongTin.Controls.Add(this.txt_MaDon);
            this.grp_ThongTin.Controls.Add(this.lbl_MaDon);
            this.grp_ThongTin.Location = new System.Drawing.Point(22, 57);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(375, 362);
            this.grp_ThongTin.TabIndex = 1;
            this.grp_ThongTin.TabStop = false;
            this.grp_ThongTin.Text = "Thông tin thú cưng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_ChamSocHo);
            this.panel1.Controls.Add(this.rad_ChuaBenh);
            this.panel1.Location = new System.Drawing.Point(79, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 44);
            this.panel1.TabIndex = 13;
            // 
            // rad_ChamSocHo
            // 
            this.rad_ChamSocHo.AutoSize = true;
            this.rad_ChamSocHo.Location = new System.Drawing.Point(145, 10);
            this.rad_ChamSocHo.Name = "rad_ChamSocHo";
            this.rad_ChamSocHo.Size = new System.Drawing.Size(106, 20);
            this.rad_ChamSocHo.TabIndex = 1;
            this.rad_ChamSocHo.TabStop = true;
            this.rad_ChamSocHo.Text = "Chăm sóc hộ";
            this.rad_ChamSocHo.UseVisualStyleBackColor = true;
            this.rad_ChamSocHo.CheckedChanged += new System.EventHandler(this.rad_ChamSocHo_CheckedChanged);
            // 
            // rad_ChuaBenh
            // 
            this.rad_ChuaBenh.AutoSize = true;
            this.rad_ChuaBenh.Location = new System.Drawing.Point(16, 10);
            this.rad_ChuaBenh.Name = "rad_ChuaBenh";
            this.rad_ChuaBenh.Size = new System.Drawing.Size(92, 20);
            this.rad_ChuaBenh.TabIndex = 0;
            this.rad_ChuaBenh.TabStop = true;
            this.rad_ChuaBenh.Text = "Chữa bệnh";
            this.rad_ChuaBenh.UseVisualStyleBackColor = true;
            this.rad_ChuaBenh.CheckedChanged += new System.EventHandler(this.rad_ChuaBenh_CheckedChanged);
            // 
            // dtp_NgayNhan
            // 
            this.dtp_NgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhan.Location = new System.Drawing.Point(93, 176);
            this.dtp_NgayNhan.Name = "dtp_NgayNhan";
            this.dtp_NgayNhan.Size = new System.Drawing.Size(252, 22);
            this.dtp_NgayNhan.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dịch vụ";
            // 
            // lbl_NgayNhan
            // 
            this.lbl_NgayNhan.AutoSize = true;
            this.lbl_NgayNhan.Location = new System.Drawing.Point(15, 176);
            this.lbl_NgayNhan.Name = "lbl_NgayNhan";
            this.lbl_NgayNhan.Size = new System.Drawing.Size(72, 16);
            this.lbl_NgayNhan.TabIndex = 10;
            this.lbl_NgayNhan.Text = "Ngày nhận";
            // 
            // txt_CPT_NCS
            // 
            this.txt_CPT_NCS.Location = new System.Drawing.Point(103, 296);
            this.txt_CPT_NCS.Name = "txt_CPT_NCS";
            this.txt_CPT_NCS.Size = new System.Drawing.Size(242, 22);
            this.txt_CPT_NCS.TabIndex = 3;
            // 
            // lbl_CPT_NCS
            // 
            this.lbl_CPT_NCS.AutoSize = true;
            this.lbl_CPT_NCS.Location = new System.Drawing.Point(15, 299);
            this.lbl_CPT_NCS.Name = "lbl_CPT_NCS";
            this.lbl_CPT_NCS.Size = new System.Drawing.Size(82, 16);
            this.lbl_CPT_NCS.TabIndex = 2;
            this.lbl_CPT_NCS.Text = "Chi phí thuốc";
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(87, 218);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(258, 22);
            this.txt_TinhTrang.TabIndex = 9;
            // 
            // lbl_TinhTrang
            // 
            this.lbl_TinhTrang.AutoSize = true;
            this.lbl_TinhTrang.Location = new System.Drawing.Point(15, 221);
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(66, 16);
            this.lbl_TinhTrang.TabIndex = 8;
            this.lbl_TinhTrang.Text = "Tình trạng";
            // 
            // txt_CanNang
            // 
            this.txt_CanNang.Location = new System.Drawing.Point(85, 137);
            this.txt_CanNang.Name = "txt_CanNang";
            this.txt_CanNang.Size = new System.Drawing.Size(260, 22);
            this.txt_CanNang.TabIndex = 7;
            // 
            // lbl_CanNang
            // 
            this.lbl_CanNang.AutoSize = true;
            this.lbl_CanNang.Location = new System.Drawing.Point(15, 140);
            this.lbl_CanNang.Name = "lbl_CanNang";
            this.lbl_CanNang.Size = new System.Drawing.Size(64, 16);
            this.lbl_CanNang.TabIndex = 6;
            this.lbl_CanNang.Text = "Cân nặng";
            // 
            // txt_ChungLoai
            // 
            this.txt_ChungLoai.Location = new System.Drawing.Point(104, 103);
            this.txt_ChungLoai.Name = "txt_ChungLoai";
            this.txt_ChungLoai.Size = new System.Drawing.Size(241, 22);
            this.txt_ChungLoai.TabIndex = 5;
            // 
            // lbl_ChungLoai
            // 
            this.lbl_ChungLoai.AutoSize = true;
            this.lbl_ChungLoai.Location = new System.Drawing.Point(15, 106);
            this.lbl_ChungLoai.Name = "lbl_ChungLoai";
            this.lbl_ChungLoai.Size = new System.Drawing.Size(70, 16);
            this.lbl_ChungLoai.TabIndex = 4;
            this.lbl_ChungLoai.Text = "Chủng loại";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(104, 64);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(241, 22);
            this.txt_Ten.TabIndex = 3;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(15, 67);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(83, 16);
            this.lbl_Ten.TabIndex = 2;
            this.lbl_Ten.Text = "Tên thú cưng";
            // 
            // txt_MaDon
            // 
            this.txt_MaDon.Location = new System.Drawing.Point(79, 29);
            this.txt_MaDon.Name = "txt_MaDon";
            this.txt_MaDon.Size = new System.Drawing.Size(266, 22);
            this.txt_MaDon.TabIndex = 1;
            // 
            // lbl_MaDon
            // 
            this.lbl_MaDon.AutoSize = true;
            this.lbl_MaDon.Location = new System.Drawing.Point(15, 32);
            this.lbl_MaDon.Name = "lbl_MaDon";
            this.lbl_MaDon.Size = new System.Drawing.Size(52, 16);
            this.lbl_MaDon.TabIndex = 0;
            this.lbl_MaDon.Text = "Mã đơn";
            // 
            // grp_DanhSachThuCung
            // 
            this.grp_DanhSachThuCung.Controls.Add(this.lv_DanhSachThuCung);
            this.grp_DanhSachThuCung.Location = new System.Drawing.Point(403, 57);
            this.grp_DanhSachThuCung.Name = "grp_DanhSachThuCung";
            this.grp_DanhSachThuCung.Size = new System.Drawing.Size(524, 362);
            this.grp_DanhSachThuCung.TabIndex = 2;
            this.grp_DanhSachThuCung.TabStop = false;
            this.grp_DanhSachThuCung.Text = "Danh sách thú cưng";
            // 
            // lv_DanhSachThuCung
            // 
            this.lv_DanhSachThuCung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_MaDon,
            this.col_TenTC,
            this.col_ChungLoai,
            this.col_NgayNhan});
            this.lv_DanhSachThuCung.FullRowSelect = true;
            this.lv_DanhSachThuCung.HideSelection = false;
            this.lv_DanhSachThuCung.Location = new System.Drawing.Point(0, 21);
            this.lv_DanhSachThuCung.Name = "lv_DanhSachThuCung";
            this.lv_DanhSachThuCung.Size = new System.Drawing.Size(524, 335);
            this.lv_DanhSachThuCung.TabIndex = 0;
            this.lv_DanhSachThuCung.UseCompatibleStateImageBehavior = false;
            this.lv_DanhSachThuCung.View = System.Windows.Forms.View.Details;
            this.lv_DanhSachThuCung.SelectedIndexChanged += new System.EventHandler(this.lv_DanhSachThuCung_SelectedIndexChanged);
            // 
            // col_MaDon
            // 
            this.col_MaDon.Text = "Mã đơn";
            this.col_MaDon.Width = 80;
            // 
            // col_TenTC
            // 
            this.col_TenTC.Text = "Tên thú cưng";
            this.col_TenTC.Width = 120;
            // 
            // col_ChungLoai
            // 
            this.col_ChungLoai.Text = "Chủng loại";
            this.col_ChungLoai.Width = 90;
            // 
            // col_NgayNhan
            // 
            this.col_NgayNhan.Text = "Ngày nhận";
            this.col_NgayNhan.Width = 100;
            // 
            // grp_TacVu
            // 
            this.grp_TacVu.Controls.Add(this.btn_ThongKe);
            this.grp_TacVu.Controls.Add(this.btn_SapXep);
            this.grp_TacVu.Controls.Add(this.btn_Sua);
            this.grp_TacVu.Controls.Add(this.btn_Xoa);
            this.grp_TacVu.Controls.Add(this.btn_Luu);
            this.grp_TacVu.Controls.Add(this.btn_Them);
            this.grp_TacVu.Location = new System.Drawing.Point(22, 425);
            this.grp_TacVu.Name = "grp_TacVu";
            this.grp_TacVu.Size = new System.Drawing.Size(932, 91);
            this.grp_TacVu.TabIndex = 3;
            this.grp_TacVu.TabStop = false;
            this.grp_TacVu.Text = "Tác vụ";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(773, 33);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(102, 35);
            this.btn_ThongKe.TabIndex = 5;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_SapXep
            // 
            this.btn_SapXep.Location = new System.Drawing.Point(630, 33);
            this.btn_SapXep.Name = "btn_SapXep";
            this.btn_SapXep.Size = new System.Drawing.Size(102, 35);
            this.btn_SapXep.TabIndex = 4;
            this.btn_SapXep.Text = "Sắp xếp";
            this.btn_SapXep.UseVisualStyleBackColor = true;
            this.btn_SapXep.Click += new System.EventHandler(this.btn_SapXep_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(487, 33);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 35);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(344, 33);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 35);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(201, 33);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(102, 35);
            this.btn_Luu.TabIndex = 1;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(58, 33);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(102, 35);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 528);
            this.Controls.Add(this.grp_TacVu);
            this.Controls.Add(this.grp_DanhSachThuCung);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6251071070_Nguyễn Tấn Phát";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_DanhSachThuCung.ResumeLayout(false);
            this.grp_TacVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.Label lbl_MaDon;
        private System.Windows.Forms.GroupBox grp_DanhSachThuCung;
        private System.Windows.Forms.GroupBox grp_TacVu;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Label lbl_TinhTrang;
        private System.Windows.Forms.TextBox txt_CanNang;
        private System.Windows.Forms.Label lbl_CanNang;
        private System.Windows.Forms.TextBox txt_ChungLoai;
        private System.Windows.Forms.Label lbl_ChungLoai;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.TextBox txt_MaDon;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_NgayNhan;
        private System.Windows.Forms.TextBox txt_CPT_NCS;
        private System.Windows.Forms.Label lbl_CPT_NCS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rad_ChamSocHo;
        private System.Windows.Forms.RadioButton rad_ChuaBenh;
        private System.Windows.Forms.ListView lv_DanhSachThuCung;
        private System.Windows.Forms.ColumnHeader col_MaDon;
        private System.Windows.Forms.ColumnHeader col_TenTC;
        private System.Windows.Forms.ColumnHeader col_ChungLoai;
        private System.Windows.Forms.ColumnHeader col_NgayNhan;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_SapXep;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Them;
    }
}

