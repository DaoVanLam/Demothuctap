namespace Demothuctap.Forms
{
    partial class frmTimHDB
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
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.cboMaHDB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(102, 102);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(121, 21);
            this.cboManhanvien.TabIndex = 56;
            // 
            // cboMaHDB
            // 
            this.cboMaHDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHDB.FormattingEnabled = true;
            this.cboMaHDB.Location = new System.Drawing.Point(102, 69);
            this.cboMaHDB.Name = "cboMaHDB";
            this.cboMaHDB.Size = new System.Drawing.Size(121, 21);
            this.cboMaHDB.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 39);
            this.label7.TabIndex = 54;
            this.label7.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(25, 129);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(417, 135);
            this.DataGridView.TabIndex = 50;
            this.DataGridView.DoubleClick += new System.EventHandler(this.DataGridView_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Demothuctap.Properties.Resources.Thoat1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(341, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 36);
            this.btnThoat.TabIndex = 82;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Image = global::Demothuctap.Properties.Resources.Timlai1;
            this.btnTimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimlai.Location = new System.Drawing.Point(183, 279);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(100, 36);
            this.btnTimlai.TabIndex = 81;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::Demothuctap.Properties.Resources.Timkiem1;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(25, 279);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 36);
            this.btnTimkiem.TabIndex = 80;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Năm";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(297, 102);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(39, 20);
            this.txtThang.TabIndex = 85;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(383, 102);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(59, 20);
            this.txtNam.TabIndex = 86;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(321, 69);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(121, 21);
            this.cboMaKhach.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Mã khách hàng";
            // 
            // frmTimHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(475, 324);
            this.ControlBox = false;
            this.Controls.Add(this.cboMaKhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboManhanvien);
            this.Controls.Add(this.cboMaHDB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmTimHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm hóa đơn bán";
            this.Load += new System.EventHandler(this.frmTimHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.ComboBox cboMaHDB;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}