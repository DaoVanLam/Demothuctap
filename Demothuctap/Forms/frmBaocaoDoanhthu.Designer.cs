namespace Demothuctap.Forms
{
    partial class frmBaocaoDoanhthu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtloinhuan2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdoanhthu2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnXem);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txtThang);
            this.groupBox2.Controls.Add(this.txtloinhuan2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtdoanhthu2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(590, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 258);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng doanh thu";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Demothuctap.Properties.Resources.Thoat1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(204, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 36);
            this.btnThoat.TabIndex = 82;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::Demothuctap.Properties.Resources.In1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(110, 216);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(94, 36);
            this.btnIn.TabIndex = 81;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXem
            // 
            this.btnXem.Image = global::Demothuctap.Properties.Resources.Hienthi1;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(16, 216);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(94, 36);
            this.btnXem.TabIndex = 80;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(277, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Doanh thu, lợi nhuận tính trên số sản phẩm đã bán được";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 26);
            this.label12.TabIndex = 74;
            this.label12.Text = "Chọn tháng có\r\ntrong dữ liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(177, 69);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 79;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(113, 24);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(53, 20);
            this.txtThang.TabIndex = 78;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtloinhuan2
            // 
            this.txtloinhuan2.Location = new System.Drawing.Point(113, 163);
            this.txtloinhuan2.Name = "txtloinhuan2";
            this.txtloinhuan2.Size = new System.Drawing.Size(177, 20);
            this.txtloinhuan2.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Lợi nhuận";
            // 
            // txtdoanhthu2
            // 
            this.txtdoanhthu2.Location = new System.Drawing.Point(113, 137);
            this.txtdoanhthu2.Name = "txtdoanhthu2";
            this.txtdoanhthu2.Size = new System.Drawing.Size(177, 20);
            this.txtdoanhthu2.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Doanh thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Năm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tháng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboThang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 96);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐIỀU KIỆN CHI TIẾT";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(291, 22);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(100, 21);
            this.cboThang.TabIndex = 41;
            this.cboThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboThang_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Điều kiện";
            // 
            // cboDK
            // 
            this.cboDK.FormattingEnabled = true;
            this.cboDK.Location = new System.Drawing.Point(68, 42);
            this.cboDK.Name = "cboDK";
            this.cboDK.Size = new System.Drawing.Size(121, 21);
            this.cboDK.TabIndex = 39;
            this.cboDK.TextChanged += new System.EventHandler(this.cboDK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(291, 54);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 32;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Năm";
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 166);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(557, 150);
            this.DataGridView.TabIndex = 45;
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::Demothuctap.Properties.Resources.Timlai1;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(449, 111);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(120, 43);
            this.btnLamlai.TabIndex = 51;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Image = global::Demothuctap.Properties.Resources.Baocao1;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(449, 61);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(120, 43);
            this.btnBaocao.TabIndex = 50;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // frmBaocaoDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(904, 333);
            this.ControlBox = false;
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmBaocaoDoanhthu";
            this.Text = "BÁO CÁP DOANH THU";
            this.Load += new System.EventHandler(this.frmBaocaoDoanhthu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtloinhuan2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdoanhthu2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnLamlai;
    }
}