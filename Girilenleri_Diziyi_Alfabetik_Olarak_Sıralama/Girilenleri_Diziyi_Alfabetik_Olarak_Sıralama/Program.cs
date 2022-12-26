using System;

namespace Girilenleri_Diziyi_Alfabetik_Olarak_Sıralama
{
    //Diziyi Alfabetik Olarak Sıralama  (Array.Sort ve Array.Reverse)  kullanarak dizinini alfabetik olarak A’ dan Z’ ye ve Z’den A’ya Sıralama
    class Program
    {
        static void Main(string[] args)
        {
            int adet;
            Console.Write("Girilecek Veri Adeti : ");//girilecek veri adetini bize sorar
            adet = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("---------------------------------------");//ekranda araya çigi boşluğu verir
            string[] liste = new string[adet];
            string isim;

            for (int i = 0; i < adet; i++)//deişkeni sıfırdan başlat adet değişkeini birer birer arttır 
            {
                Console.Write(i + 1 + ". İsmi Giriniz: ");
                isim = Console.ReadLine();
                liste[i] = isim;
            }

            Console.WriteLine();
            Console.WriteLine("Sıralamadan önce liste:");
            Console.WriteLine("---------------------------------------");//ekranda araya çigi boşluğu verir

            foreach (string eleman in liste)//diziin içindeki dögüyü strin eleman içinde listele
            {
                Console.WriteLine(eleman);
            }


            Array.Sort(liste);
            Console.WriteLine();
            Console.WriteLine("A-Z Sıralama:");//ekrana yazar A-Z Sıralama: diye
            Console.WriteLine("---------------------------------------");//ekranda araya çigi boşluğu verir

            foreach (string eleman in liste)//diziin içindeki dögüyü strin eleman içinde listele
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine();
            Array.Reverse(liste);
            Console.WriteLine("Z-A Sıralama:");//ekrana yazar Z-A  Sıralama: diye
            Console.WriteLine("---------------------------------------");//ekranda araya çigi boşluğu verir

            foreach (string eleman in liste) //diziin içindeki dögüyü strin eleman içinde listele
            {
                Console.WriteLine(eleman);
            }

            Console.ReadKey();
        }
    }
}
