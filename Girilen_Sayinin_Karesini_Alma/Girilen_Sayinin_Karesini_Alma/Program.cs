using System;

namespace Girilen_Sayinin_Karesini_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı  : ");//ekrana sayi: yazdırıyoruz  5 girdiimizde
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi * sayi; // burda sayinin karesini alma işlemini son deikeie atadık aynı sayıyı iki kez çarpmakdır karesi almak
            Console.WriteLine(sayi + " sayısının karesi : " + sonuc); //ekrana sayinin karesi alınmıs ekilde yazacaktir   25 olaca

            Console.ReadKey();
        }
    }
}
