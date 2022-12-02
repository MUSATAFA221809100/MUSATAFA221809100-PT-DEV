using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinası
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam, fark, bölüm, çarpım;
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            bölüm = sayi1 / sayi2;
            çarpım = sayi1 * sayi2;
            Console.WriteLine("toplam :{0},fark :{1},bölüm: {2},çarpım={3}",toplam,fark,bölüm,çarpım);
            Console.ReadLine();
        }

    }
}
