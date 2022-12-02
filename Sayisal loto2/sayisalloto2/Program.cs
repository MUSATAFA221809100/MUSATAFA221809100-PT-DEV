


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sayisalloto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] rastgele = new int[6];
            for (int i = 0; i < 6; i++)
            {
                rastgele[i] = rnd.Next(2, 49);
            }

            Array.Sort(rastgele);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(rastgele[i] + "");
            }

            Console.ReadLine();
        }

    }
}
