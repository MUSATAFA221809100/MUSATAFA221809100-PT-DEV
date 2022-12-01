using System;
using System.Linq;
using System.Threading.Tasks;

namespace sayıdeğerleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, işlem1, art = 1, devmalılık= 1;
            Console.WriteLine("1.sayiyi giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayiyi giriniz.");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bu sayıları arasındaki sayıları; sırasıyla küçükten büyüğe doğru 1 ,  büyükten küçüğe doğru içi 0 girin");
            işlem1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıların kaçar kaçar artış göstermeli 7");
            art= Convert.ToInt32(Console.ReadLine());
            if (işlem1 == 0)
            {
                if (sayi1 < sayi2)
                    for (; sayi1 <= sayi2; sayi1 += art)
                    {
                        Console.WriteLine(sayi1);
                        if (sayi1 >= sayi2) break;

                    }

                if (sayi2 < sayi1)
                    for (; sayi2 <= sayi1; sayi2 += art)
                    {
                        Console.WriteLine(sayi2);
                        if (sayi2 >= sayi1) break;

                    }

                if (işlem1 == 1)
                {

                    if (sayi1 > sayi2)

                        for (; sayi1 >= sayi2; sayi1 -= art)
                        {
                            Console.WriteLine(sayi1);
                            if (sayi1 == sayi2) break;
                        }

                    if (sayi2 > sayi1)
                        for (; sayi2 >= sayi1; sayi2 -= art)
                        {
                            Console.WriteLine(sayi2);
                            if (sayi1 >= sayi2) break;
                        }






                }
            
            }
        }













       

    }
}
/* hangi iki sayi arasındaki sayılarin kullanıcıdan istein algoritma genelolucak iki tam sayi arasında sayi ile görüntülenecek ve artan sıra mı azalan siralamamı, sıralı sayılara mı çifter mi*/