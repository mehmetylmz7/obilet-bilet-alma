using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Vehicle
    {
        void CalculateFuelCost()
        {

        }
        public string HangiFirma {  get; set; }
        public string AracID { get; set; }
        public string  YakitTuru { get; set; }
        public string Kapasite { get; set; }
        public string SeferNo { get; set; }

    }

    public class Bus :Vehicle
    {
        public Bus()
        { 
        
        }
        public Bus(string hangifirma, string aracid , string yakitturu,string  kapasite ,string seferno)
        {
            this.HangiFirma = hangifirma;
            this.AracID = aracid;
            this.YakitTuru = yakitturu;
            this.Kapasite = kapasite;
            this.SeferNo = seferno;
        }


    }
    public class Train : Vehicle
    {
        public Train()
        {

        }
        public Train(string hangifirma, string aracid, string yakitturu, string  kapasite, string seferno)
        {
            this.HangiFirma = hangifirma;
            this.AracID = aracid;
            this.YakitTuru = yakitturu;
            this.Kapasite = kapasite;
            this.SeferNo = seferno;
        }
    }
    public class Airplane : Vehicle
    {
        public Airplane()
        {

        }
        public Airplane(string hangifirma, string aracid, string yakitturu, string  kapasite, string seferno)
        {
            this.HangiFirma = hangifirma;
            this.AracID = aracid;
            this.YakitTuru = yakitturu;
            this.Kapasite = kapasite;
            this.SeferNo = seferno;
        }
    }
}
