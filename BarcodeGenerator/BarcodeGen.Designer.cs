
namespace BarcodeGenerator
{
    partial class BarcodeGen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_FirmCode = new System.Windows.Forms.TextBox();
            this.txt_CountryCode = new System.Windows.Forms.TextBox();
            this.btn_Uret = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_BarcodeNum = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 202);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(38, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "BARKOD OLUŞTURMA SİHİRBAZINA HOŞGELDİNİZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarcodeGenerator.Properties.Resources.B_Pixelp1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.txt_FirmCode);
            this.panel2.Controls.Add(this.txt_CountryCode);
            this.panel2.Controls.Add(this.btn_Uret);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 173);
            this.panel2.TabIndex = 2;
            // 
            // txt_FirmCode
            // 
            this.txt_FirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_FirmCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirmCode.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_FirmCode.Location = new System.Drawing.Point(134, 53);
            this.txt_FirmCode.Name = "txt_FirmCode";
            this.txt_FirmCode.Size = new System.Drawing.Size(288, 23);
            this.txt_FirmCode.TabIndex = 1;
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_CountryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CountryCode.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_CountryCode.Location = new System.Drawing.Point(134, 24);
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.Size = new System.Drawing.Size(288, 23);
            this.txt_CountryCode.TabIndex = 1;
            // 
            // btn_Uret
            // 
            this.btn_Uret.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Uret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Uret.Location = new System.Drawing.Point(67, 105);
            this.btn_Uret.Name = "btn_Uret";
            this.btn_Uret.Size = new System.Drawing.Size(320, 54);
            this.btn_Uret.TabIndex = 0;
            this.btn_Uret.Text = "Barkod Oluştur";
            this.btn_Uret.UseVisualStyleBackColor = false;
            this.btn_Uret.Click += new System.EventHandler(this.btn_Uret_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "FİRMA KODU : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÜLKE KODU : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.lbl_BarcodeNum);
            this.panel3.Location = new System.Drawing.Point(12, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 102);
            this.panel3.TabIndex = 3;
            // 
            // lbl_BarcodeNum
            // 
            this.lbl_BarcodeNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_BarcodeNum.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_BarcodeNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_BarcodeNum.Location = new System.Drawing.Point(7, 10);
            this.lbl_BarcodeNum.Name = "lbl_BarcodeNum";
            this.lbl_BarcodeNum.Size = new System.Drawing.Size(437, 83);
            this.lbl_BarcodeNum.TabIndex = 0;
            this.lbl_BarcodeNum.Text = "BARKODUNUZ BURADA GÖRÜNECEKTİR";
            this.lbl_BarcodeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 536);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 286);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(7, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 262);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Download
            // 
            this.btn_Download.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Download.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Download.Location = new System.Drawing.Point(12, 828);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(450, 60);
            this.btn_Download.TabIndex = 5;
            this.btn_Download.Text = "PDF OLARAK İNDİR";
            this.btn_Download.UseVisualStyleBackColor = false;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // BarcodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 939);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BarcodeGen";
            this.Text = "Barkod Oluşturucu";
            this.Load += new System.EventHandler(this.BarcodeGen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_FirmCode;
        private System.Windows.Forms.TextBox txt_CountryCode;
        private System.Windows.Forms.Button btn_Uret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_BarcodeNum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Download;
    }
}

