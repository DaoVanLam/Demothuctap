namespace Demothuctap.Forms
{
    partial class frmBaocaoHangton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenthuoc = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTenthuoc);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 63);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng còn";
            // 
            // cboTenthuoc
            // 
            this.cboTenthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenthuoc.FormattingEnabled = true;
            this.cboTenthuoc.Location = new System.Drawing.Point(93, 25);
            this.cboTenthuoc.Name = "cboTenthuoc";
            this.cboTenthuoc.Size = new System.Drawing.Size(132, 21);
            this.cboTenthuoc.TabIndex = 14;
            this.cboTenthuoc.TextChanged += new System.EventHandler(this.cboTenthuoc_TextChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(333, 26);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(132, 20);
            this.txtSoluong.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên thuốc";
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(8, 76);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(485, 148);
            this.DataGridView.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "BÁO CÁO HÀNG TỒN";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Image = global::Demothuctap.Properties.Resources.Hienthi1;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(499, 76);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(101, 49);
            this.btnBaocao.TabIndex = 25;
            this.btnBaocao.Text = "Hiển thị";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::Demothuctap.Properties.Resources.In1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(499, 159);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 49);
            this.btnIn.TabIndex = 26;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Demothuctap.Properties.Resources.Thoat1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(499, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 49);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaocaoHangton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(612, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmBaocaoHangton";
            this.Text = "Báo cáo hàng tồn";
            this.Load += new System.EventHandler(this.frmBaocaoHangton_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenthuoc;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
    }
}