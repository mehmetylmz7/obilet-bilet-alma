﻿namespace WindowsFormsApp1
{
    partial class FirmaPaneli
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aractipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitturu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aracturu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guzargah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arac Ekleme Ve Cikarma";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "1. sefer",
            "2. sefer",
            "3. sefer",
            "4. sefer",
            "5. sefer",
            "6. sefer",
            ""});
            this.comboBox7.Location = new System.Drawing.Point(123, 234);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 24);
            this.comboBox7.TabIndex = 7;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sefer No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracid,
            this.aractipi,
            this.yakitturu,
            this.kapasite,
            this.seferno});
            this.dataGridView1.Location = new System.Drawing.Point(268, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 497);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aracid
            // 
            this.aracid.HeaderText = "Arac ID";
            this.aracid.MinimumWidth = 6;
            this.aracid.Name = "aracid";
            this.aracid.Width = 125;
            // 
            // aractipi
            // 
            this.aractipi.HeaderText = "Arac Tipi";
            this.aractipi.MinimumWidth = 6;
            this.aractipi.Name = "aractipi";
            this.aractipi.Width = 125;
            // 
            // yakitturu
            // 
            this.yakitturu.HeaderText = "Yakit Turu";
            this.yakitturu.MinimumWidth = 6;
            this.yakitturu.Name = "yakitturu";
            this.yakitturu.Width = 125;
            // 
            // kapasite
            // 
            this.kapasite.HeaderText = "Kapasite";
            this.kapasite.MinimumWidth = 6;
            this.kapasite.Name = "kapasite";
            this.kapasite.Width = 75;
            // 
            // seferno
            // 
            this.seferno.HeaderText = "SeferNo";
            this.seferno.MinimumWidth = 6;
            this.seferno.Name = "seferno";
            this.seferno.Width = 125;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Goster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guncelle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30"});
            this.comboBox3.Location = new System.Drawing.Point(123, 189);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kapasite";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Otobus",
            "Tren",
            "Ucak"});
            this.comboBox2.Location = new System.Drawing.Point(123, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arac Tipi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Benzin",
            "Motorin",
            "Elektrik",
            "Gaz"});
            this.comboBox1.Location = new System.Drawing.Point(123, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yakit Turu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arac ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1039, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sefer Ekleme Ve Cikarma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracturu,
            this.guzargah,
            this.zaman,
            this.fiyat});
            this.dataGridView2.Location = new System.Drawing.Point(204, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(819, 413);
            this.dataGridView2.TabIndex = 4;
            // 
            // aracturu
            // 
            this.aracturu.HeaderText = "Arac Turu";
            this.aracturu.MinimumWidth = 6;
            this.aracturu.Name = "aracturu";
            // 
            // guzargah
            // 
            this.guzargah.HeaderText = "Guzergah";
            this.guzargah.MinimumWidth = 6;
            this.guzargah.Name = "guzargah";
            // 
            // zaman
            // 
            this.zaman.HeaderText = "Zaman";
            this.zaman.MinimumWidth = 6;
            this.zaman.Name = "zaman";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.MinimumWidth = 6;
            this.fiyat.Name = "fiyat";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(902, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(847, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fiyat";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "4 Aralik",
            "5 Aralik",
            "6 Aralik",
            "7 Aralik",
            "8 Aralik",
            "9 Aralik",
            "10 Aralik"});
            this.comboBox6.Location = new System.Drawing.Point(708, 54);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 2;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1.sefer (DY)˙Istanbul - Kocaeli - Bilecik - Eskisehir - Ankara",
            "2.sefer (DY): ˙Istanbul - Kocaeli - Bilecik - Eskisehir - Konya",
            "3.sefer (KY):˙Istanbul - Kocaeli - Ankara",
            "4.sefer (KY):˙Istanbul - Kocaeli - Eskisehir - Konya",
            "5.sefer (HY):˙Istanbul - Konya",
            "6.sefer (HY):˙Istanbul - Ankara"});
            this.comboBox5.Location = new System.Drawing.Point(296, 54);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(341, 24);
            this.comboBox5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zaman";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Otobus",
            "Tren",
            "Ucak"});
            this.comboBox4.Location = new System.Drawing.Point(83, 54);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Guzergah";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arac Turu";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1039, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gunluk Kar Hesapla";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // FirmaPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FirmaPaneli";
            this.Text = "FirmaPaneli";
            this.Load += new System.EventHandler(this.FirmaPaneli_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracid;
        private System.Windows.Forms.DataGridViewTextBoxColumn aractipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasite;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn guzargah;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label7;
    }
}