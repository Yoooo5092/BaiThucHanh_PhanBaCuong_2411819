namespace BaiTapWindowsForm2
{
    partial class frmBai3
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGhepChuoi = new System.Windows.Forms.Button();
            this.btnTinhGiaiThua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(129, 98);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 4;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(129, 65);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 20);
            this.txtHo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ";
            // 
            // btnGhepChuoi
            // 
            this.btnGhepChuoi.Location = new System.Drawing.Point(54, 197);
            this.btnGhepChuoi.Name = "btnGhepChuoi";
            this.btnGhepChuoi.Size = new System.Drawing.Size(102, 23);
            this.btnGhepChuoi.TabIndex = 6;
            this.btnGhepChuoi.Text = "Ghép chuỗi";
            this.btnGhepChuoi.UseVisualStyleBackColor = true;
            this.btnGhepChuoi.Click += new System.EventHandler(this.btnGhepChuoi_Click);
            // 
            // btnTinhGiaiThua
            // 
            this.btnTinhGiaiThua.Location = new System.Drawing.Point(54, 226);
            this.btnTinhGiaiThua.Name = "btnTinhGiaiThua";
            this.btnTinhGiaiThua.Size = new System.Drawing.Size(102, 23);
            this.btnTinhGiaiThua.TabIndex = 7;
            this.btnTinhGiaiThua.Text = "Tính giai thừa";
            this.btnTinhGiaiThua.UseVisualStyleBackColor = true;
            this.btnTinhGiaiThua.Click += new System.EventHandler(this.btnTinhGiaiThua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(129, 133);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 4;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(200, 226);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết quả";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 325);
            this.Controls.Add(this.btnTinhGiaiThua);
            this.Controls.Add(this.btnGhepChuoi);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGhepChuoi;
        private System.Windows.Forms.Button btnTinhGiaiThua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblKetQua;
    }
}