using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace girilen_sayıları_büyükten_küçüğe_sıralama
{
    // girilen sayıları büyükten küçüğe sıralama
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, gecicideğişkeni, EnBuyukYer;
            int[] A = { 78, 56, 23, 95, 68, 87, 61, 77, 45, 33 };
            for (i = 0; i <= A.Length - 1; i++)
            {
                EnBuyukYer = i;//1-1. EnBuyukYer=0, EnBuyukYer=1
                for (j = i + 1; j <= A.Length - 1; j++)
                {//2-1. J=1, j=2, j=3, j=4, j=5, j=6, j=7, j=8, j=9—2-2 j=2
                    if (A[j] > A[EnBuyukYer])
                        EnBuyukYer = j;//2-1 EnBuyukYer=1, EnBuyukYer=2, 
                }
                gecicideğişkeni = A[i];//1.1. gecici değişkenini=78
                A[i] = A[EnBuyukYer];//1-1 A[0]=23
                A[EnBuyukYer] = gecicideğişkeni;//1-1 A[2]=78 //{23,56,78,95,68,87,61,77,45,33}
                Console.WriteLine(A[i]);// 23
            }
            Console.Write("DEVAM ETMEK İÇİN HERHANGİ BİR TUŞA BASINIZ . . . ");
            Console.ReadKey(true);

        }
    }
}
