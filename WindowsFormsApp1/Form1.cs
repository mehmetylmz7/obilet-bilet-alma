using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public  List<Admin> admin = new List<Admin>();
        public  List<Company> sirketler =new List<Company>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi=tboxKa.Text;
            string sifre=tboxPassword.Text;

            foreach (Admin admin in admin)
            {
                if(kullaniciadi==admin.getKullaniciAdi()&&sifre==admin.getPassword())
                {
                    // admin sayfasina yonlendirme
                    
                }
                
            }
            foreach(Company company in sirketler)
            {
                if(kullaniciadi==company.getKullaniciAdi()&&sifre==company.getPassword())
                {
                    // firma paneline yonlendir
                   

                }
            }

               
        }

        private void tboxKa_TextChanged(object sender, EventArgs e)
        {
            admin.Add(new Admin("admin", "admin"));
            sirketler.Add(new Company("A", "afirmasi"));
            sirketler.Add(new Company("B", "bfirmasi"));
            sirketler.Add(new Company("C", "cfirmasi"));
            sirketler.Add(new Company("D", "dfirmasi"));
            sirketler.Add(new Company("F", "ffirmasi"));


        }

        private void txt_kullanicipanelegiris_Click(object sender, EventArgs e)
        {
            // kullanici paneline yonlendir
           

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {
              
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // firma paneline gidiyor
            firmapanelinegirispaneli firmapanelinegirispaneli1 =new firmapanelinegirispaneli();
            firmapanelinegirispaneli1.Show();
            this.Hide();
        }
    }
}
