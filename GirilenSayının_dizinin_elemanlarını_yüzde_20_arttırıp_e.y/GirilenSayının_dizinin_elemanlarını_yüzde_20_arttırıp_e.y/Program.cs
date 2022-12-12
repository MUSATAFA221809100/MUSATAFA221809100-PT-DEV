using System;

namespace GirilenSayının_dizinin_elemanlarını_yüzde_20_arttırıp_e.y_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcı tarafından 10 elemanlı bir diziye sayı girişi yaptıran ve bu dizinin elemanlarını %20 arttırıp ekrana yazdıran For döngüsü örneği

          
            //Eleman Girme işlemi
            int[] dizi = new int[10];
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("{0}. elemanı giriniz : ", i + 1);
                        dizi[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("=========================================");
                  
            // Yazdırma işlemi
                    for (int i = 0; i < 10; i++)
                    {
                        dizi[i] = dizi[i] + (dizi[i] * 20 / 100);
                        Console.WriteLine("Dizinin {0}. indexi : {1} ", i, dizi[i]);
                    }
                    Console.ReadKey();
            
           
        }
    }
}
