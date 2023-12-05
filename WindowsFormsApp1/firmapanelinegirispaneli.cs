using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class firmapanelinegirispaneli : Form
    {
        public List<Company> sirketler = new List<Company>();


        public static string FirmaAdi { get; private set; }

        public firmapanelinegirispaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firmaAdi = textBox1.Text;
            string firmaPassword=textBox2.Text;
            

            sirketler.Add(new Company("A", "afirmasi"));
            sirketler.Add(new Company("B", "bfirmasi"));
            sirketler.Add(new Company("C", "cfirmasi"));
            sirketler.Add(new Company("D", "dfirmasi"));
            sirketler.Add(new Company("F", "ffirmasi"));

            foreach (Company company in sirketler)
            {
                if (firmaAdi == company.getKullaniciAdi() && firmaPassword == company.getPassword())
                {
                    FirmaAdi = firmaAdi;
                    MessageBox.Show("giris basarili");

                    // firma paneline yonlendir
                    FirmaPaneli firmaPaneli = new FirmaPaneli();
                    firmaPaneli.Show();
                    break;

                }
            }
            
        }

        private void firmapanelinegirispaneli_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
