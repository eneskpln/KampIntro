using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Aşağı Yönlü Ok");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Yukarı Yönlü Ok");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

           // if (sistemeGirisYapmisMi == true)
            //{
             //   Console.WriteLine("Kullanıcı Ayarlar Butonu");
            //}
            //else
            //{
              //  Console.WriteLine("Giriş Yap Butonu");
            //}

            //Console.WriteLine(kategoriEtiketi);
        }
    }
}
