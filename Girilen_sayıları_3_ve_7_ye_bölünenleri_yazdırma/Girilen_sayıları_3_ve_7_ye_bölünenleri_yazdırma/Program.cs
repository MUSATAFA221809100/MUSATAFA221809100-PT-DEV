using System;

namespace Girilen_sayıları_3_ve_7_ye_bölünenleri_yazdırma
{
    class Program
    {

       // Kullanıcının girdiği sayıya kadar olan sayılardan 3 e ve 7 ye tam bölünebilen sayıları listeleyen program 
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Gir : ");// ekraa yazar sayıyı gir diye yazar // 250 yazdığımızda
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) //döngü i 1 de başlayarak i  n değerine küçüktür vea eşitire kadar devam etsin ve birer birer artar
            {
                if (i % 3 == 0 && i % 7 == 0)//asıl işlemi yani 3 ve 7 bçmlerin yapıldığı yer
                {
                    Console.Write("{0} ", i); //21 42 63  84 105 126 147 168 189 210 231 yazar sonuçta
                }
            }
            Console.ReadKey();
        }
    }
}
