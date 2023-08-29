namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtSoyad = new TextBox();
            txtad = new TextBox();
            label3 = new Label();
            msknumara = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGuncelle = new Button();
            txtSınav1 = new TextBox();
            txtSınav3 = new TextBox();
            txtSınav2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            lblortalama = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            lblKalanSayisi = new Label();
            lblGecenSayisi = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(msknumara);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(19, 14);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(365, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(89, 176);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 5;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(89, 128);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(144, 26);
            txtSoyad.TabIndex = 4;
            // 
            // txtad
            // 
            txtad.Location = new Point(89, 96);
            txtad.Name = "txtad";
            txtad.Size = new Size(144, 26);
            txtad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 131);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // msknumara
            // 
            msknumara.Location = new Point(89, 50);
            msknumara.Mask = "0000";
            msknumara.Name = "msknumara";
            msknumara.Size = new Size(144, 26);
            msknumara.TabIndex = 3;
            msknumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 99);
            label2.Name = "label2";
            label2.Size = new Size(37, 18);
            label2.TabIndex = 2;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 53);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 1;
            label1.Text = "Numara";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(txtSınav1);
            groupBox2.Controls.Add(txtSınav3);
            groupBox2.Controls.Add(txtSınav2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(394, 14);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(365, 221);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(89, 176);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(144, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Öğrenci Kaydet";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtSınav1
            // 
            txtSınav1.Location = new Point(89, 52);
            txtSınav1.Name = "txtSınav1";
            txtSınav1.Size = new Size(144, 26);
            txtSınav1.TabIndex = 4;
            // 
            // txtSınav3
            // 
            txtSınav3.Location = new Point(89, 128);
            txtSınav3.Name = "txtSınav3";
            txtSınav3.Size = new Size(144, 26);
            txtSınav3.TabIndex = 4;
            // 
            // txtSınav2
            // 
            txtSınav2.Location = new Point(89, 96);
            txtSınav2.Name = "txtSınav2";
            txtSınav2.Size = new Size(144, 26);
            txtSınav2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 132);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 2;
            label4.Text = "Sınav 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 100);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 2;
            label5.Text = "Sınav 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 54);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 1;
            label6.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblortalama);
            groupBox3.Controls.Add(lblGecenSayisi);
            groupBox3.Controls.Add(lblKalanSayisi);
            groupBox3.Location = new Point(769, 14);
            groupBox3.Margin = new Padding(5, 4, 5, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 4, 5, 4);
            groupBox3.Size = new Size(369, 221);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Notları";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(90, 52);
            label9.Name = "label9";
            label9.Size = new Size(110, 23);
            label9.TabIndex = 3;
            label9.Text = "Ortalama:";
            // 
            // lblortalama
            // 
            lblortalama.AutoSize = true;
            lblortalama.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblortalama.Location = new Point(206, 51);
            lblortalama.Name = "lblortalama";
            lblortalama.Size = new Size(36, 23);
            lblortalama.TabIndex = 4;
            lblortalama.Text = "00";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(19, 243);
            groupBox4.Margin = new Padding(5, 4, 5, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 4, 5, 4);
            groupBox4.Size = new Size(1119, 337);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1109, 310);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblKalanSayisi
            // 
            lblKalanSayisi.AutoSize = true;
            lblKalanSayisi.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKalanSayisi.Location = new Point(209, 115);
            lblKalanSayisi.Name = "lblKalanSayisi";
            lblKalanSayisi.Size = new Size(36, 23);
            lblKalanSayisi.TabIndex = 6;
            lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            lblGecenSayisi.AutoSize = true;
            lblGecenSayisi.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGecenSayisi.Location = new Point(206, 84);
            lblGecenSayisi.Name = "lblGecenSayisi";
            lblGecenSayisi.Size = new Size(36, 23);
            lblGecenSayisi.TabIndex = 5;
            lblGecenSayisi.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(60, 84);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 2;
            label8.Text = "Geçen Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(60, 115);
            label7.Name = "label7";
            label7.Size = new Size(143, 23);
            label7.TabIndex = 1;
            label7.Text = "Kalan Sayısı :";
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1177, 584);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            Load += FrmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtSoyad;
        private TextBox txtad;
        private Label label3;
        private MaskedTextBox msknumara;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGuncelle;
        private TextBox txtSınav1;
        private TextBox txtSınav3;
        private TextBox txtSınav2;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label9;
        private Label lblortalama;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private Label lblGecenSayisi;
        private Label lblKalanSayisi;
    }
}