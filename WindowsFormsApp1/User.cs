using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public interface ILoginable
    {
        //giris yapma yetenegine sahip nesneleri temsil eder
    } 
    public interface IProfitable
    {
        //Bu Interface, kar ve gelir hesaplama yetene˘gine sahip nesneleri
        // temsil eder.Bu Interface i¸cinde g¨unl¨uk kar hesabı ve genel kar-zar hesabı
        //metotları yer almalıdır.Bu Interface Company class’ında implement edilmelidir.
        void GunlukKarHesabi();
        void GenelKarZarHesabi();
    }

    public abstract class User : ILoginable
    {
        // admin ve company siniflarina ait ortak metot ve degiskenler burada tanımlanmali
        public string  KullaniAdi { get; set; }
        public string Password { get; set; }

         

        public User(string kullanciadi , string password )
        {
             
            this.Password = password;
            this.KullaniAdi = kullanciadi;
        }


        public void setKullaniciAdi(string KullaniAdi)
        {
            this.KullaniAdi = KullaniAdi;
        }
        public string getKullaniciAdi()
        {
            return this.KullaniAdi;
        }

        public void setPassword(string Password)
        {
            this.Password=Password;
        }
        public string getPassword()
        {
            return this.Password;
        }
        


    }

    public class Admin : User
    {
        List<Admin> admin = new List<Admin>();
        List<Company> sirketler = new List<Company>();

        public Admin(string kullanciadi, string password) : base(kullanciadi, password)
        {
        }

        public void FirmalariGoruntule()
        {
             foreach (Admin admin in admin)
            {
                Console.WriteLine(admin);
            }
        }
        public void FirmaKaydiYap()
        {
            
        }
        public void FirmaKaydiSil()
        {

        }
        public void HizmetBedeliBelirle()
        {
            
        }
    }
    public class Company : User , IProfitable
    {
        public Company(string kullanciadi, string password) : base(kullanciadi, password)
        {
        }

        public  string  AracBilgisi { get; set; }


        public void AracEkleme()
        {
            
        }
        public void AracCikarma()
        {

        }
        public void SeferEkleme()
        {

        }
         public void SeferCikarma()
        {

        }

        public void GunlukKarHesabi()
        {
            throw new NotImplementedException();
        }

        public void GenelKarZarHesabi()
        {
            throw new NotImplementedException();
        }
    }
}
