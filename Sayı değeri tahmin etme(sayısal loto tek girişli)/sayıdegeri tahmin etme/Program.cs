using System;
using System.Collections.Generic;
using System.Text;

namespace sayıdegeri_tahmin_etme
{
    class Program

    /*  sayı tahmin ettme programıdır tek sayi girebilirsiniz ve sistem kendi içindeki algoritamsından  seçer ver doğru veya yanlış bildiniz diye bilgilendirir ve doğru cevaplancıya kadar çalıışır ve devam ettirebilinir */


    {
        static void Main(string[] args)
        { 
           Random _rnd = new Random();
        int _uretilenSayi = _rnd.Next(10, 21);

            Console.WriteLine("bir sayi tahmin ediniz..");
            while(true)
            {
                int _tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
         
            if(_tahminEdilenSayi == _uretilenSayi)
        
            {
                Console.WriteLine("Tebrikler doğru tahmin ettiniz..");

                  break;
            }    
               
                else 
                {
                        Console.WriteLine("yanlış tahminde bulundunuz . Lütfen tekrar deneyiniz....");
              
                
                }
              
            }

            Console.ReadLine();

        }
    }
}
