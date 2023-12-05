using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Person 
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }


    }
    public class Personal : Person
    {

    }
    public class Passenger : Person
    {
        public string  YolcuAdi { get; set; }
        public string YolcuSoyadi { get; set; }
        public string YolcuTC {  get; set; }
        public string DogumTarihi { get; set; }
    }


}
