using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_ilk_50_asal_asal_sayiyi_yazdırma
{
    class Program
    {
        //girilen sayıların ilk 50 asal sayı 10′ arlı olarak ekranda yazdırma
        static void Main(string[] args)
        {
            int sayi = 2; // sayı değişknine 2 verdik  çükü asal sayılar alailmemiz için
            int sayac = 0; //sayaç deişkeni 0 vedik
            int sayac2 = 0; //sayaç 2 deişkeni 0 vedik
            int sayac3 = 0; //sayaç3 deişkeni 0 vedik
            Console.WriteLine("İlk 50 Asal Sayı");     //ekrana    İlk 50 Asal Sayı  yazar
            while (true)
            {

                sayac = 0;
                if (sayac2 == 50)
                {
                    break; //sayi değişeni birer birer  arttır
                }
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;//sayaç değişeni birer birer  arttır
                        break; // bitikten sonra döngüyü bırak
                    }

                }
                if (sayac == 0)
                {
                    sayac3++;
                    Console.Write(sayi + "\t");
                    if (sayac3 % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                    sayac2++;
                }
                sayi++; //sayi değişeni birer birer  arttır
            }

            Console.ReadKey();
        }
    }
}
