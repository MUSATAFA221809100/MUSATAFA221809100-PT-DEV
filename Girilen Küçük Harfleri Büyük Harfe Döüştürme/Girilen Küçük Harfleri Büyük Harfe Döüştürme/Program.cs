using System;

namespace Girilen_Küçük_Harfleri_Büyük_Harfe_Döüştürme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin giriniz ( Türkçe karekter kullamayınız ): ");// ekrana metn girmemizi isteyecek türkçe karekter kulanmamız istemkteyimm
            string metin = Console.ReadLine();

            for ( int i=0; i<metin.Legenth; i++) // dizimiz sıfırıncı indisten  başalyacak metinin uzunluğu kadar çalışacak.
            {
                int a = metin[i]; //metindeki aski kodlar ile yaılacak
                int b = a - 32; // her karekteriçin aynı döngüden ilerler taki metin.legent döndürülecek karekter bitti deinceye kadar
                Console.Write((char)b);

            }
            Console.ReadKey();
        }

    }
}
