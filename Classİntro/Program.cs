using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adi = "Engin";
            //int yas = 38;
            //Console.WriteLine(adi);
            //Console.WriteLine(yas);
            //Console.WriteLine("-----");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 18;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.izlenmeOrani = 31;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Sadık Turan";
            kurs3.izlenmeOrani = 62;

            //Console.WriteLine("Kurs Adı: " + kurs1.KursAdi + " " + "Eğitmen: " + kurs1.Egitmen + " " + "Bitirme Oranı: " + kurs1.izlenmeOrani);

            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kursDongusu in Kurslar)
            {
                Console.WriteLine("Kurs Adı: " + kursDongusu.KursAdi + ", " + "Eğitmen: " + kursDongusu.Egitmen + ", " + "İlerleme Oranı: " + kursDongusu.izlenmeOrani);
                Console.WriteLine("---");
            }




        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }

}