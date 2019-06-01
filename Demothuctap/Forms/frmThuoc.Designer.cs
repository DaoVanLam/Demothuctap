namespace Demothuctap.Forms
{
    partial class frmThuoc
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCongdung = new System.Windows.Forms.TextBox();
            this.cboDonvitinh = new System.Windows.Forms.ComboBox();
            this.txtThanhphan = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtChongchidinh = new System.Windows.Forms.TextBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskNgaysx = new System.Windows.Forms.MaskedTextBox();
            this.mskHansd = new System.Windows.Forms.MaskedTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMathuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboManhomthuoc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Demothuctap.Properties.Resources.Thoat1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(677, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 42);
            this.btnThoat.TabIndex = 186;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(9, 372);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(762, 161);
            this.DataGridView.TabIndex = 180;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCongdung);
            this.groupBox2.Controls.Add(this.cboDonvitinh);
            this.groupBox2.Controls.Add(this.txtThanhphan);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.txtDongiaban);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtChongchidinh);
            this.groupBox2.Controls.Add(this.txtDongianhap);
            this.groupBox2.Location = new System.Drawing.Point(9, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 139);
            this.groupBox2.TabIndex = 179;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết loại thuốc";
            // 
            // txtCongdung
            // 
            this.txtCongdung.Location = new System.Drawing.Point(344, 56);
            this.txtCongdung.Multiline = true;
            this.txtCongdung.Name = "txtCongdung";
            this.txtCongdung.Size = new System.Drawing.Size(280, 25);
            this.txtCongdung.TabIndex = 165;
            // 
            // cboDonvitinh
            // 
            this.cboDonvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonvitinh.FormattingEnabled = true;
            this.cboDonvitinh.Location = new System.Drawing.Point(107, 47);
            this.cboDonvitinh.Name = "cboDonvitinh";
            this.cboDonvitinh.Size = new System.Drawing.Size(126, 21);
            this.cboDonvitinh.TabIndex = 164;
            // 
            // txtThanhphan
            // 
            this.txtThanhphan.Location = new System.Drawing.Point(344, 10);
            this.txtThanhphan.Multiline = true;
            this.txtThanhphan.Name = "txtThanhphan";
            this.txtThanhphan.Size = new System.Drawing.Size(280, 42);
            this.txtThanhphan.TabIndex = 162;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 161;
            this.label18.Text = "Thành phần";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 145;
            this.label14.Text = "Đơn giá bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 143;
            this.label13.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Công dụng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Chống chỉ định";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(107, 23);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(126, 20);
            this.txtSoluong.TabIndex = 130;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(107, 102);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(126, 20);
            this.txtDongiaban.TabIndex = 146;
            this.txtDongiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongiaban_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "Đơn giá nhập";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 124;
            this.label16.Text = "Số lượng hiện có";
            // 
            // txtChongchidinh
            // 
            this.txtChongchidinh.Location = new System.Drawing.Point(344, 84);
            this.txtChongchidinh.Multiline = true;
            this.txtChongchidinh.Name = "txtChongchidinh";
            this.txtChongchidinh.Size = new System.Drawing.Size(280, 37);
            this.txtChongchidinh.TabIndex = 133;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(107, 76);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(126, 20);
            this.txtDongianhap.TabIndex = 131;
            this.txtDongianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongianhap_KeyPress);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::Demothuctap.Properties.Resources.Boqua1;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(677, 270);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(94, 42);
            this.btnBoqua.TabIndex = 185;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskNgaysx);
            this.groupBox1.Controls.Add(this.mskHansd);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.picAnh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMathuoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenthuoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboManhomthuoc);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 178);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // mskNgaysx
            // 
            this.mskNgaysx.Location = new System.Drawing.Point(97, 111);
            this.mskNgaysx.Mask = "00/00/0000";
            this.mskNgaysx.Name = "mskNgaysx";
            this.mskNgaysx.Size = new System.Drawing.Size(136, 20);
            this.mskNgaysx.TabIndex = 147;
            this.mskNgaysx.ValidatingType = typeof(System.DateTime);
            // 
            // mskHansd
            // 
            this.mskHansd.Location = new System.Drawing.Point(97, 144);
            this.mskHansd.Mask = "00/00/0000";
            this.mskHansd.Name = "mskHansd";
            this.mskHansd.Size = new System.Drawing.Size(136, 20);
            this.mskHansd.TabIndex = 148;
            this.mskHansd.ValidatingType = typeof(System.DateTime);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(264, 44);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 37);
            this.btnOpen.TabIndex = 146;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(344, 16);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(280, 27);
            this.txtAnh.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 143;
            this.label11.Text = "Ảnh";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(344, 52);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(161, 111);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 145;
            this.picAnh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Mã thuốc";
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Location = new System.Drawing.Point(97, 19);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(136, 20);
            this.txtMathuoc.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Tên thuốc";
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Location = new System.Drawing.Point(97, 48);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(136, 20);
            this.txtTenthuoc.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Ngày sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Hạn sử dụng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "Nhóm thuốc";
            // 
            // cboManhomthuoc
            // 
            this.cboManhomthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManhomthuoc.FormattingEnabled = true;
            this.cboManhomthuoc.Location = new System.Drawing.Point(97, 80);
            this.cboManhomthuoc.Name = "cboManhomthuoc";
            this.cboManhomthuoc.Size = new System.Drawing.Size(136, 21);
            this.cboManhomthuoc.TabIndex = 140;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(258, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 31);
            this.label12.TabIndex = 177;
            this.label12.Text = "DANH MỤC THUỐC";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::Demothuctap.Properties.Resources.Luu1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(677, 178);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 42);
            this.btnLuu.TabIndex = 184;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::Demothuctap.Properties.Resources.Them1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(677, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 42);
            this.btnThem.TabIndex = 181;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Demothuctap.Properties.Resources.Delete1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(677, 86);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 42);
            this.btnXoa.TabIndex = 182;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::Demothuctap.Properties.Resources.Sua1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(677, 132);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 42);
            this.btnSua.TabIndex = 183;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::Demothuctap.Properties.Resources.Timkiem1;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(677, 224);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(94, 42);
            this.btnTimkiem.TabIndex = 187;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(785, 544);
            this.ControlBox = false;
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "frmThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Danh mục Thuốc";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDonvitinh;
        private System.Windows.Forms.TextBox txtThanhphan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtChongchidinh;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMathuoc;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboManhomthuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtCongdung;
        private System.Windows.Forms.MaskedTextBox mskNgaysx;
        private System.Windows.Forms.MaskedTextBox mskHansd;
        private System.Windows.Forms.Button btnTimkiem;
    }
}