using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyat = 15;
            urun1.aciklama = "Amasya Elması";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.fiyat = 80;
            urun2.aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun herUrunicin in urunler)
            {
                Console.WriteLine("Ürün Adı: " + herUrunicin.Adi);
                Console.WriteLine("Fiyatı: " + herUrunicin.fiyat);
                Console.WriteLine("Ürün Açıklaması: " + herUrunicin.aciklama);
                Console.WriteLine("-----");
            }
            Console.WriteLine("---------Metotlar-------");

            //instance
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 12, 10);
            sepetManager.Ekle2("Elma", "Sarı", 13, 9);
            sepetManager.Ekle2("Portakal", "Turuncu", 14, 8);

        }
    }
}
