namespace Demothuctap.Forms
{
    partial class frmHoadonban
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
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.DataGridViewChitiet = new System.Windows.Forms.DataGridView();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.cboMathuoc = new System.Windows.Forms.ComboBox();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMakhach = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.txtNgayban = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChitiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(394, 383);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(131, 20);
            this.txtTongtien.TabIndex = 111;
            // 
            // DataGridViewChitiet
            // 
            this.DataGridViewChitiet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChitiet.Location = new System.Drawing.Point(15, 413);
            this.DataGridViewChitiet.Name = "DataGridViewChitiet";
            this.DataGridViewChitiet.Size = new System.Drawing.Size(713, 167);
            this.DataGridViewChitiet.TabIndex = 110;
            this.DataGridViewChitiet.DoubleClick += new System.EventHandler(this.DataGridViewChitiet_DoubleClick);
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(12, 386);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(53, 13);
            this.lblBangchu.TabIndex = 121;
            this.lblBangchu.Text = "Bằng chữ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDongiaban);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.cboMathuoc);
            this.groupBox2.Controls.Add(this.txtTenthuoc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 127);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(438, 35);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(100, 20);
            this.txtDongiaban.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Đơn giá";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(68, 59);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 20);
            this.txtSoluong.TabIndex = 49;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(263, 61);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhtien.TabIndex = 48;
            // 
            // cboMathuoc
            // 
            this.cboMathuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMathuoc.FormattingEnabled = true;
            this.cboMathuoc.Location = new System.Drawing.Point(68, 32);
            this.cboMathuoc.Name = "cboMathuoc";
            this.cboMathuoc.Size = new System.Drawing.Size(100, 21);
            this.cboMathuoc.TabIndex = 46;
            this.cboMathuoc.TextChanged += new System.EventHandler(this.cboMathuoc_TextChanged);
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Location = new System.Drawing.Point(263, 35);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(100, 20);
            this.txtTenthuoc.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Thành tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tên thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mã thuốc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(336, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 112;
            this.label15.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMakhach);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenkhach);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtDienthoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboManhanvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaHDBan);
            this.groupBox1.Controls.Add(this.txtNgayban);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 174);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboMakhach
            // 
            this.cboMakhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMakhach.FormattingEnabled = true;
            this.cboMakhach.Location = new System.Drawing.Point(454, 42);
            this.cboMakhach.Name = "cboMakhach";
            this.cboMakhach.Size = new System.Drawing.Size(100, 21);
            this.cboMakhach.TabIndex = 63;
            this.cboMakhach.TextChanged += new System.EventHandler(this.cboMakhach_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Mã khách hàng";
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(454, 69);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(100, 20);
            this.txtTenkhach.TabIndex = 58;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(454, 95);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi.TabIndex = 57;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(454, 121);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienthoai.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tên nhân viên";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(111, 117);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(138, 20);
            this.txtTennhanvien.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã nhân viên";
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(111, 90);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(138, 21);
            this.cboManhanvien.TabIndex = 52;
            this.cboManhanvien.TextChanged += new System.EventHandler(this.cboManhanvien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ngày bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(111, 38);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(138, 20);
            this.txtMaHDBan.TabIndex = 49;
            // 
            // txtNgayban
            // 
            this.txtNgayban.Location = new System.Drawing.Point(111, 64);
            this.txtNgayban.Name = "txtNgayban";
            this.txtNgayban.Size = new System.Drawing.Size(138, 20);
            this.txtNgayban.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(226, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(290, 42);
            this.label17.TabIndex = 122;
            this.label17.Text = "HÓA ĐƠN BÁN";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::Demothuctap.Properties.Resources.Thoat1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(607, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 49);
            this.btnThoat.TabIndex = 147;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::Demothuctap.Properties.Resources.In1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(607, 266);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(121, 49);
            this.btnIn.TabIndex = 146;
            this.btnIn.Text = "In ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::Demothuctap.Properties.Resources.Boqua1;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(607, 197);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 49);
            this.btnHuy.TabIndex = 145;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::Demothuctap.Properties.Resources.Luu1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(607, 128);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 49);
            this.btnLuu.TabIndex = 144;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::Demothuctap.Properties.Resources.Them1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(607, 59);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 49);
            this.btnThem.TabIndex = 143;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(749, 597);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.DataGridViewChitiet);
            this.Controls.Add(this.lblBangchu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Name = "frmHoadonban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmHoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChitiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.DataGridView DataGridViewChitiet;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.ComboBox cboMathuoc;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMakhach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayban;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.TextBox txtMaHDBan;
    }
}