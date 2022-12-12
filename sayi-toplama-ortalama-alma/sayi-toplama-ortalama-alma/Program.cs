using System;

namespace sayi_toplama_ortalama_alma
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double toplam = 0, ortalama = 0;
                Console.Write("Kaç elemanlı dizi oluşturulsun :");// Ekrana yazacak en başta kaç elemanlı dizi oluşturulsun diye [5 elemanlı olarak]
                int n = Int32.Parse(Console.ReadLine());
                double[] dizi = new double[n];
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write("Sayı {0}: ", i + 1);
                    dizi[i] = Convert.ToDouble(Console.ReadLine());
                    toplam += dizi[i];
                }
                ortalama = toplam / dizi.Length; // Ekrana girilmiş olan sayıların toplayıp kaç adet girilmiş olan sayıya bölerek ortalamasını bulur ve orlama değişkenine atar
                Console.WriteLine("Toplam : " + toplam); // Ekrana girilmiş olan sayıların toplamını yazar
                Console.WriteLine("Ortalama : " + ortalama);// Ekrana girilmiş olan sayıların toplayıp kaç adet girilmiş olan sayıya bölerek ortalamasını ekrana yazar
                Console.ReadKey();
            }

        }
    }
}
