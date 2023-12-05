namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txt_kullanicipanelegiris = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxKa = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_kullanicipanelegiris
            // 
            this.txt_kullanicipanelegiris.AutoSize = true;
            this.txt_kullanicipanelegiris.Location = new System.Drawing.Point(487, 226);
            this.txt_kullanicipanelegiris.Name = "txt_kullanicipanelegiris";
            this.txt_kullanicipanelegiris.Size = new System.Drawing.Size(155, 16);
            this.txt_kullanicipanelegiris.TabIndex = 6;
            this.txt_kullanicipanelegiris.Text = "kullanici olarak devam et";
            this.txt_kullanicipanelegiris.Click += new System.EventHandler(this.txt_kullanicipanelegiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "sifre";
            // 
            // tboxKa
            // 
            this.tboxKa.Location = new System.Drawing.Point(35, 65);
            this.tboxKa.Name = "tboxKa";
            this.tboxKa.Size = new System.Drawing.Size(279, 22);
            this.tboxKa.TabIndex = 0;
            this.tboxKa.TextChanged += new System.EventHandler(this.tboxKa_TextChanged);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(35, 132);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(279, 22);
            this.tboxPassword.TabIndex = 1;
            this.tboxPassword.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(35, 193);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(247, 83);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giris Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "kullanici adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Firma paneline git";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(725, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kullanicipanelegiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxKa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_kullanicipanelegiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxKa;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

