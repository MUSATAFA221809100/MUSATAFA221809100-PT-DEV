using System;

namespace dizinin_elemanlarını_küçükten_büyüğe_doğru_sıralama_algrtma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, gecici, EnKucukYer;
            int[] A = { 78, 56, 23, 95, 68, 87, 61, 77, 45, 33 };
            for (i = 0; i <= A.Length - 1; i++)
            {
                EnKucukYer = i;// EnKucukYer=0, EnKucukYer=1
                for (j = i + 1; j <= A.Length - 1; j++)
                {// J=1, j=2, j=3, j=4, j=5, j=6, j=7, j=8, j=9—2-2 j=2
                    if (A[j] < A[EnKucukYer]) EnKucukYer = j;// enkucukyer=1, enkucukyer=2
                }
                gecici = A[i];// gecici=78(en büyük)
                A[i] = A[EnKucukYer];// A[0]=23
                A[EnKucukYer] = gecici;// A[2]=78 ({23,56,78,95,68,87,61,77,45,33})
                Console.WriteLine(A[i]);//  23 (en küçük)
            }
            Console.Write("DEVAM ETMEK İÇİN HERHANGİ BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}





    

