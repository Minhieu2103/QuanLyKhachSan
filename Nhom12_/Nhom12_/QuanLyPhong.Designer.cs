namespace Nhom12_
{
    partial class QuanLyPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyPhong));
            this.label5 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDongDSPhong = new System.Windows.Forms.Button();
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.udSLNguoi = new System.Windows.Forms.NumericUpDown();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSLNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.imageList2;
            this.label5.Location = new System.Drawing.Point(0, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(678, 92);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quản Lý Phòng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "living-room.png");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(690, 1113);
            this.panel5.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.udSLNguoi);
            this.groupBox2.Controls.Add(this.cbTrangThai);
            this.groupBox2.Controls.Add(this.cbLoaiPhong);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(690, 1113);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaPhong);
            this.groupBox3.Controls.Add(this.btnDongDSPhong);
            this.groupBox3.Controls.Add(this.btnCapNhatPhong);
            this.groupBox3.Controls.Add(this.btnTimKiemPhong);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnThemPhong);
            this.groupBox3.Location = new System.Drawing.Point(32, 571);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(652, 525);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.ImageIndex = 2;
            this.btnXoaPhong.ImageList = this.imageList1;
            this.btnXoaPhong.Location = new System.Drawing.Point(36, 238);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(466, 65);
            this.btnXoaPhong.TabIndex = 28;
            this.btnXoaPhong.Text = "Xóa Phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "customer-service-agent.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "hotel.png");
            this.imageList1.Images.SetKeyName(4, "pay.png");
            this.imageList1.Images.SetKeyName(5, "performance.png");
            this.imageList1.Images.SetKeyName(6, "plus.png");
            this.imageList1.Images.SetKeyName(7, "update.png");
            this.imageList1.Images.SetKeyName(8, "QLDV.png");
            // 
            // btnDongDSPhong
            // 
            this.btnDongDSPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongDSPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongDSPhong.ImageIndex = 0;
            this.btnDongDSPhong.ImageList = this.imageList1;
            this.btnDongDSPhong.Location = new System.Drawing.Point(36, 427);
            this.btnDongDSPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongDSPhong.Name = "btnDongDSPhong";
            this.btnDongDSPhong.Size = new System.Drawing.Size(466, 83);
            this.btnDongDSPhong.TabIndex = 30;
            this.btnDongDSPhong.Text = "Đóng Danh Sách Phòng";
            this.btnDongDSPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongDSPhong.UseVisualStyleBackColor = true;
            this.btnDongDSPhong.Click += new System.EventHandler(this.btnDongDSPhong_Click);
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatPhong.ImageIndex = 7;
            this.btnCapNhatPhong.ImageList = this.imageList1;
            this.btnCapNhatPhong.Location = new System.Drawing.Point(36, 137);
            this.btnCapNhatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(466, 65);
            this.btnCapNhatPhong.TabIndex = 26;
            this.btnCapNhatPhong.Text = "Cập Nhật Phòng";
            this.btnCapNhatPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatPhong.Click += new System.EventHandler(this.btnCapNhatPhong_Click);
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhong.ImageIndex = 6;
            this.btnTimKiemPhong.ImageList = this.imageList1;
            this.btnTimKiemPhong.Location = new System.Drawing.Point(410, 329);
            this.btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(238, 75);
            this.btnTimKiemPhong.TabIndex = 29;
            this.btnTimKiemPhong.Text = "Tìm Kiếm";
            this.btnTimKiemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            this.btnTimKiemPhong.Click += new System.EventHandler(this.btnTimKiemPhong_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 340);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(368, 44);
            this.txtSearch.TabIndex = 24;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhong.ImageIndex = 6;
            this.btnThemPhong.ImageList = this.imageList1;
            this.btnThemPhong.Location = new System.Drawing.Point(36, 35);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(466, 65);
            this.btnThemPhong.TabIndex = 27;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // udSLNguoi
            // 
            this.udSLNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udSLNguoi.Location = new System.Drawing.Point(32, 410);
            this.udSLNguoi.Margin = new System.Windows.Forms.Padding(6);
            this.udSLNguoi.Name = "udSLNguoi";
            this.udSLNguoi.Size = new System.Drawing.Size(582, 44);
            this.udSLNguoi.TabIndex = 32;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã Đặt"});
            this.cbTrangThai.Location = new System.Drawing.Point(32, 304);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(6);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(578, 45);
            this.cbTrangThai.TabIndex = 31;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Deluxe",
            "Standard",
            "Superior",
            "Sulte"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(32, 196);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(6);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(578, 45);
            this.cbLoaiPhong.TabIndex = 31;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(32, 85);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(578, 44);
            this.txtMaPhong.TabIndex = 21;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(32, 512);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(578, 44);
            this.txtDonGia.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 462);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 42);
            this.label6.TabIndex = 20;
            this.label6.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 42);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số người tối đa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Trang Thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loại Phòng";
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhong.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 51;
            this.dataGridViewPhong.RowTemplate.Height = 24;
            this.dataGridViewPhong.Size = new System.Drawing.Size(1244, 1077);
            this.dataGridViewPhong.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPhong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1256, 1113);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Dịch Vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(700, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 1113);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(1984, 1133);
            this.panel3.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1984, 98);
            this.panel1.TabIndex = 35;
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1249);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyPhong";
            this.Text = "QuanLyPhong";
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSLNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDongDSPhong;
        private System.Windows.Forms.Button btnCapNhatPhong;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.NumericUpDown udSLNguoi;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}