using System;

namespace Girilen_Sayıların_Bütün_Beğerlerini_Bulma
{
    // Girilen Sayılardan En Büyük – En Küçük – Toplam – Ortalama – Negatif ve Pozitif Sayısı Bulma
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayiAdet, toplam = 0, ortalama = 0, enBuyuk, enKucuk, pozitifAdet = 0, negatifAdet = 0;
            Console.WriteLine("Girilen Sayıların En Büyüğü - En Küçüğü - Pozitif Adeti - Negatif Adeti - Toplam - Ortalamasını Bulma");//ekrana Girilen Sayıların En Büyüğü - En Küçüğü - Pozitif Adeti - Negatif Adeti - Toplam - Ortalamasını Bulma yazar
            Console.WriteLine("=======================================================================================================");// araya bosluk bırakm çizgisi dir
            Console.Write("Girilecek Sayı Adetini Girin : ");//ekran Girilecek Sayı Adetini Giri yazacak      6 >> 50 30 -40 -20 10 30 
            sayiAdet = Int32.Parse(Console.ReadLine());
            enBuyuk = int.MinValue; //enbuyuk değeri int.minvalue değeriyle alacak
            enKucuk = int.MaxValue;//enkücük değeri int.maxvalue değeriyle alacak
            for (int i = 1; i <= sayiAdet; i++)
            {
                Console.Write("Sayıyı Gir :  ");//ekrana sayıyı gir yazacak
                sayi = Int32.Parse(Console.ReadLine());
                if (sayi > enBuyuk) //sayi büyüktür en büyük dögüsüü kuracak
                {
                    enBuyuk = sayi;
                }
                if (sayi < enKucuk)//sayi küçüktür enkücük dögüsüü kuracak
                {
                    enKucuk = sayi;
                }
                if (sayi < 0) //sayi küçükse sıfırdan
                {
                    negatifAdet++; //negatifAdet ++ arttır
                }
                if (sayi > 0) //sayi büyükse sıfırdan
                {
                    pozitifAdet++;//pozitifAdet ++ arttır
                }
                toplam += sayi;
            }
            ortalama = toplam / sayiAdet;
            Console.WriteLine();
            Console.WriteLine("==================================================================================="); // ekran ara bölücü çizgisi yapar
            Console.WriteLine("Girilen Sayı Adeti : " + sayiAdet);//ekrana "Girilen Sayı Adeti : yazar                           6
            Console.WriteLine("Girilen Sayıların Toplamı : " + toplam);//ekrana Girilen Sayıların Toplamı : yazacak              60
            Console.WriteLine("Girilen Sayıların Ortalaması : " + ortalama);//ekrana Girilen Sayıların Ortalaması : yazacak      10     
            Console.WriteLine("Girilen Sayıların En Küçüğü : " + enKucuk);//ekrana Girilen Sayıların En Küçüğü : yazacak        - 40
            Console.WriteLine("Girilen Sayıların En Büyüğü : " + enBuyuk);//ekrana Girilen Sayıların En Büyüğü : yazacak         50
            Console.WriteLine("Girilen Pozitif Sayı Adeti : " + pozitifAdet);//ekrana Girilen Pozitif Sayı Adeti :yazacak        4
            Console.WriteLine("Girilen Negatif Sayı Adeti : " + negatifAdet);//ekrana Girilen Negatif Sayı Adeti :yazacak         2
            Console.ReadKey();
        }
    }
    
}
