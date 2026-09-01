namespace ThongTinGiangVien
{
    partial class frmTimGV
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
            this.btnTimGV = new System.Windows.Forms.Button();
            this.txtTimGV = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdMaSo = new System.Windows.Forms.RadioButton();
            this.gbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimGV
            // 
            this.btnTimGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimGV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTimGV.Location = new System.Drawing.Point(356, 88);
            this.btnTimGV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimGV.Name = "btnTimGV";
            this.btnTimGV.Size = new System.Drawing.Size(74, 24);
            this.btnTimGV.TabIndex = 7;
            this.btnTimGV.Text = "Tìm";
            this.btnTimGV.UseVisualStyleBackColor = true;
            this.btnTimGV.Click += new System.EventHandler(this.btnTimGV_Click);
            // 
            // txtTimGV
            // 
            this.txtTimGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimGV.Location = new System.Drawing.Point(165, 88);
            this.txtTimGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimGV.Name = "txtTimGV";
            this.txtTimGV.Size = new System.Drawing.Size(188, 26);
            this.txtTimGV.TabIndex = 6;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(63, 95);
            this.lblMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(101, 19);
            this.lblMa.TabIndex = 5;
            this.lblMa.Text = "Nhập thông tin:";
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.rdSoDT);
            this.gbTim.Controls.Add(this.rdTen);
            this.gbTim.Controls.Add(this.rdMaSo);
            this.gbTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTim.Location = new System.Drawing.Point(63, 16);
            this.gbTim.Margin = new System.Windows.Forms.Padding(2);
            this.gbTim.Name = "gbTim";
            this.gbTim.Padding = new System.Windows.Forms.Padding(2);
            this.gbTim.Size = new System.Drawing.Size(368, 68);
            this.gbTim.TabIndex = 4;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoDT.Location = new System.Drawing.Point(236, 33);
            this.rdSoDT.Margin = new System.Windows.Forms.Padding(2);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(106, 23);
            this.rdSoDT.TabIndex = 1;
            this.rdSoDT.TabStop = true;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTen.Location = new System.Drawing.Point(136, 33);
            this.rdTen.Margin = new System.Windows.Forms.Padding(2);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(68, 23);
            this.rdTen.TabIndex = 1;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Họ tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSo
            // 
            this.rdMaSo.AutoSize = true;
            this.rdMaSo.Checked = true;
            this.rdMaSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaSo.Location = new System.Drawing.Point(32, 33);
            this.rdMaSo.Margin = new System.Windows.Forms.Padding(2);
            this.rdMaSo.Name = "rdMaSo";
            this.rdMaSo.Size = new System.Drawing.Size(74, 23);
            this.rdMaSo.TabIndex = 0;
            this.rdMaSo.TabStop = true;
            this.rdMaSo.Text = "Mã GV";
            this.rdMaSo.UseVisualStyleBackColor = true;
            // 
            // frmTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 130);
            this.Controls.Add(this.btnTimGV);
            this.Controls.Add(this.txtTimGV);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.gbTim);
            this.Name = "frmTimGV";
            this.Text = "frmTimGV";
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimGV;
        private System.Windows.Forms.TextBox txtTimGV;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMaSo;
    }
}