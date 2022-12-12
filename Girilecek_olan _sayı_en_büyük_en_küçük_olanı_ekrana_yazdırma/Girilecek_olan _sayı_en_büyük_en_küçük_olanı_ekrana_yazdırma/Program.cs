using System;

namespace Girilecek_olan__sayı_en_büyük_en_küçük_olanı_ekrana_yazdırma
{
    class Program
    {

        //Klavyeden girilecek olan 10 sayıdan en büyük ve en küçük olanı ekrana yazdıran program
        static void Main(string[] args)
        {
            int buyuk = 0, kucuk = 0, sayi;
            for (int i = 1; i <= 10; i++) //1 den 10a kadar sayıları 1er arttırır
             {
                Console.Write("{0}. sayıyı giriniz: ", i);//bizden sayıyı girmemizi ister ekrana yazdıracaktır "sayıyı giriniz" diye
                sayi = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    buyuk = sayi;
                    kucuk = sayi;
                }
                if (kucuk > sayi)
                { kucuk = sayi; }
                if (buyuk < sayi)
                { buyuk = sayi; }

            }

            Console.WriteLine("En büyük sayı {0}", buyuk);//ekrana en büyük sayıyı yazar
            Console.WriteLine("En küçük sayı {0}", kucuk);//ekrana en küçük sayıyı yazar
            Console.ReadKey();
        }
    }
}
