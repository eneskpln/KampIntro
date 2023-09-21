using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Enes", "Duygu", "Betül", "Eray" };//new komutunu yazdığın an yeni bir adres tanımlanır ve öncekinden farklı olur.
            //Console.WriteLine(isimler[0]); 
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Zeynep";

            //List<string> isimler2 = new List<string>();  //Bu satır liste oluşturmanın birinci yolu.
            //isimler2.Add("Enes");

            List<string> isimler3 = new List<string> {"Enes","Duygu","Betül","Eray"}; //Bu da liste oluşturmanın 2. yolu.
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("Zeynep");
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);  //Koleksiyonlar ile liste oluşturduğumuzda arrayde olduğu gibi elemanlar kaybedilmez okunabilir.





        }
    }
}
