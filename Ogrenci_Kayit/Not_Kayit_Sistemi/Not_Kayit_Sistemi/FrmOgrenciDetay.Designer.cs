namespace Not_Kayit_Sistemi
{
    partial class FrmOgrenciDetay
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
            label1 = new Label();
            lblAdSoyad = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblNumara = new Label();
            label8 = new Label();
            lblOrtalama = new Label();
            lblsinav3 = new Label();
            lblsinav2 = new Label();
            lblsinav1 = new Label();
            label13 = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(101, 35);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(44, 18);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 107);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 0;
            label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 139);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 0;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 170);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 0;
            label5.Text = "Sınav 3:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 63);
            label6.Name = "label6";
            label6.Size = new Size(82, 18);
            label6.TabIndex = 0;
            label6.Text = "Numara:";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(101, 63);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(48, 18);
            lblNumara.TabIndex = 0;
            lblNumara.Text = "0000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 200);
            label8.Name = "label8";
            label8.Size = new Size(94, 18);
            label8.TabIndex = 0;
            label8.Text = "Ortalama:";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(105, 200);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(28, 18);
            lblOrtalama.TabIndex = 0;
            lblOrtalama.Text = "00";
            // 
            // lblsinav3
            // 
            lblsinav3.AutoSize = true;
            lblsinav3.Location = new Point(105, 170);
            lblsinav3.Name = "lblsinav3";
            lblsinav3.Size = new Size(28, 18);
            lblsinav3.TabIndex = 0;
            lblsinav3.Text = "00";
            // 
            // lblsinav2
            // 
            lblsinav2.AutoSize = true;
            lblsinav2.Location = new Point(105, 139);
            lblsinav2.Name = "lblsinav2";
            lblsinav2.Size = new Size(28, 18);
            lblsinav2.TabIndex = 0;
            lblsinav2.Text = "00";
            // 
            // lblsinav1
            // 
            lblsinav1.AutoSize = true;
            lblsinav1.Location = new Point(105, 107);
            lblsinav1.Name = "lblsinav1";
            lblsinav1.Size = new Size(28, 18);
            lblsinav1.TabIndex = 0;
            lblsinav1.Text = "00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 242);
            label13.Name = "label13";
            label13.Size = new Size(72, 18);
            label13.TabIndex = 0;
            label13.Text = "Durum:";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(101, 242);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 18);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "Null";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(272, 336);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNumara);
            Controls.Add(lblsinav1);
            Controls.Add(lblsinav2);
            Controls.Add(lblsinav3);
            Controls.Add(lblOrtalama);
            Controls.Add(lblDurum);
            Controls.Add(lblAdSoyad);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Cornsilk;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAdSoyad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblNumara;
        private Label label8;
        private Label lblOrtalama;
        private Label lblsinav3;
        private Label lblsinav2;
        private Label lblsinav1;
        private Label label13;
        private Label lblDurum;
    }
}