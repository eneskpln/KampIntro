using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerveReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;  //Bu satırda sayi1'i sayi2'nin değerine eşitler ve sayi2 ile irtibatı keser ve sayi1 = 30 olur.
            sayi2 = 65;
            // sayi1 = 30 olur...

            //Değer tiplerde değer ataması yapılır, referans tiplerde ise referans yani adres numarası atanır...
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  //Sayılar2'nin referans numarasını sayılar1'e atamış olduk ...
            sayilar2[0] = 999; //sayılar2 dizisinde 0.eleman 999 olur
            //sayilar1[0] = 999 olur


        }
    }
}
