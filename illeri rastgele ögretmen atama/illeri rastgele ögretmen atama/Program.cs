using System;

namespace illeri_rastgele_ögretmen_atama
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int sayi, a;
                string[] il = { "MUĞLA", "AYDIN", "İZMİR", "ANTALYA", "İSTANBUL", "BOLU", "ANKARA" };
                string[] isim = { "MUSTAFA", "ALİ", "AYŞE", "AHMET", "YAKUP", "EFE", "EMRE" };
                bool[] D = new bool[7];
                for (a = 0; a <= 6; a++) Console.WriteLine("Bool D dizisinin " + a + ". elemanı= " + D[a]);
                Random rastgele = new Random();
                for (a = 0; a <= 6; a++)
                {
                    do
                    { 
                        //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engeller.
                        sayi = rastgele.Next(0, 7); 
                        //sıfır dahil ama 7 dahil değil 
                    } while (D[sayi] == true);
                    D[sayi] = true;
                    Console.WriteLine(il[a] + "\t= " + isim[sayi]);
                }
                for (a = 0; a <= 6; a++) Console.WriteLine("Bool D dizisinin " + a + ". elemanı= " + D[a]);
                Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
                Console.ReadKey(true);
            }

        }
    }
}
    

