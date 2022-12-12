using System;

namespace Direkt_girilenSayilari_toplama_ortalama_alma
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //Girilen sayıları direkt toplamlar ve bir alt satırda ise ortalamasını verir

            //Ana programda oluşturacağımız dizi 20 elemanlı olacak ve içine 1-100 arası rastgele değerler  girilmiş olacak.
          
            // EKRANA GİRİLE SAYILARIN TOPLAMINI VE ORTLAMSINI YAZAN PROGRAM
           
            //Topla isimli metodumuz dizi türünden parametre alarak int türünden değer döndürecek.

            //Yine aynı şekilde Ortalama isimli metodumuzda dizi türünde parametre alarak geriye farklı olarak double türünde bir değer döndürecek.
            
                Random rnd = new Random();
                int[] sayilar = new int[20];
                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar[i] = rnd.Next(1, 100);
                }

                Console.WriteLine("Dizi içindeki sayıların toplamı :" + Topla(sayilar)); //Girilen sayıları  toplamlar ve ekran yazar
            Console.WriteLine("-----------------------------------------------"); //Ekranda cıan sonucların arasına cizgi bir değeri yoktur görsel amaçlıdır
                Console.WriteLine("Dizi içindeki sayıların ortalaması :" + Ortalama(sayilar)); //Girilen sayıların sayıların ortalmasını ekrana yazar
            Console.WriteLine("-----------------------------------------------"); //Ekranda cıan sonucların arasına cizgi bir değeri yoktur görsel amaçlıdır
                Console.ReadKey();
            }

            public static int Topla(int[] dizi) //Toplama işlemini gerçekleştiren diziler
            {
                int toplam = 0;
                for (int i = 0; i < dizi.Length; ++i)
                    toplam += dizi[i];
                return toplam;
            }

            public static double Ortalama(int[] dizi)// Ortalama işlemini gerçekleştiren diziler
        {
                double ortalama = 0;
                int toplam = 0;
                for (int i = 0; i < dizi.Length; ++i)
                { toplam += dizi[i]; }
                ortalama = (double)toplam / (dizi.Length);
                return ortalama;
        

        }
    }
}
