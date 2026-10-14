namespace BaiThucHanhBuoi3
{
    partial class frmReadJsonFile
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnDocFIleXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(98, 29);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(160, 28);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc file JSON";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnDocFIleXML
            // 
            this.btnDocFIleXML.Location = new System.Drawing.Point(98, 77);
            this.btnDocFIleXML.Name = "btnDocFIleXML";
            this.btnDocFIleXML.Size = new System.Drawing.Size(160, 28);
            this.btnDocFIleXML.TabIndex = 0;
            this.btnDocFIleXML.Text = "Đọc file XML";
            this.btnDocFIleXML.UseVisualStyleBackColor = true;
            this.btnDocFIleXML.Click += new System.EventHandler(this.btnDocFIleXML_Click);
            // 
            // frmReadJsonFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 117);
            this.Controls.Add(this.btnDocFIleXML);
            this.Controls.Add(this.btnDocFile);
            this.Name = "frmReadJsonFile";
            this.Text = "frmReadJsonFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnDocFIleXML;
    }
}

