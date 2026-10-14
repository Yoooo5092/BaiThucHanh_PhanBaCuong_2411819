namespace QuanLyThongTinSinhVien
{
    partial class frmTuyChon
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
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSinhVien = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTIm = new System.Windows.Forms.Button();
            this.txtTuyChon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNgaySinh);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(70, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Location = new System.Drawing.Point(279, 19);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(72, 17);
            this.rdNgaySinh.TabIndex = 0;
            this.rdNgaySinh.Text = "Ngày sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(149, 19);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(57, 17);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.Text = "Họ tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSinhVien
            // 
            this.rdMaSinhVien.AutoSize = true;
            this.rdMaSinhVien.Checked = true;
            this.rdMaSinhVien.Location = new System.Drawing.Point(29, 19);
            this.rdMaSinhVien.Name = "rdMaSinhVien";
            this.rdMaSinhVien.Size = new System.Drawing.Size(85, 17);
            this.rdMaSinhVien.TabIndex = 0;
            this.rdMaSinhVien.TabStop = true;
            this.rdMaSinhVien.Text = "Mã sinh viên";
            this.rdMaSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTIm);
            this.groupBox2.Controls.Add(this.txtTuyChon);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(70, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnTIm
            // 
            this.btnTIm.Location = new System.Drawing.Point(299, 16);
            this.btnTIm.Name = "btnTIm";
            this.btnTIm.Size = new System.Drawing.Size(75, 23);
            this.btnTIm.TabIndex = 2;
            this.btnTIm.Text = "Tìm";
            this.btnTIm.UseVisualStyleBackColor = true;
            this.btnTIm.Click += new System.EventHandler(this.btnTIm_Click);
            // 
            // txtTuyChon
            // 
            this.txtTuyChon.Location = new System.Drawing.Point(101, 20);
            this.txtTuyChon.Name = "txtTuyChon";
            this.txtTuyChon.Size = new System.Drawing.Size(181, 20);
            this.txtTuyChon.TabIndex = 1;
            this.txtTuyChon.TextChanged += new System.EventHandler(this.txtTuyChon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(291, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(142, 262);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 341);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTuyChon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaSinhVien;
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTIm;
        private System.Windows.Forms.TextBox txtTuyChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSapXep;
    }
}