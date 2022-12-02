using System;

namespace ConsoleApp5
{
    class Program
    {
        /*
            * 
           * 6 rakamdan oluşur 
           * 6 adet rakam girmemizi istiyecek
           * girdiğimiz rakamları büyükten küçüğe sıralayacak
           * sistem otomatik olarak 6 adet rakam üretecek
           * sistem otomatik olarak 6 adet rakam üretecek ama rakamlar biribirinin aynısı olmayacak
           * bizim tahmin ettiğimiz rakamlarla sistemin ürettiği rakamları karşılaştıracak
           * bize kazanç rapororu sunacak
           * sayısal lotoyu tutturamadınız 

            */


        static void Main(string[] args)

        {

            Program prg = new Program();
            Random sayiUret = new Random();

            List<int> gelenler = new List<int>();
            List<int> uretilenler = new List<int>();
            gelenler = prg.gonder();

            for (int i = 0; i < 6; i++)
            {
                int tahminEdilenler = sayiUret.Next(1, 50);
                if (uretilenler.Contains(tahminEdilenler))
                {
                    i++;
                }
                else
                {
                    uretilenler.Add(tahminEdilenler);
                }
            }


            uretilenler.Sort();
            gelenler.Sort();

            int tutmaAdedi = 0;
            string tutanlar = "";
            for (int i = 0; i < 6; i++)
            {
                if (uretilenler.Contains(gelenler[i]))
                {
                    tutmaAdedi++;
                    tutanlar += Convert.ToString(gelenler[i]);

                }

                if (tutmaAdedi>0)
                {
                    Console.WriteLine(tutmaAdedi + " adedi sayı tutturdunuz. Tutan Rakamlar: "+ tutanlar +"\nkazancınız: " + tutmaAdedi*200+ "TL dir...");
                }
                else
                {
                    Console.WriteLine("maalesef kazanamadınız..");
                }
                Console.ReadLine();

            }

            public List<int> gonder()
            {


                Console.WriteLine("1 İLE 49  arasında 6 adet rakam giriniz...");
                string_girilenler = Console.ReadLine();
                string[] _parcala;
                _parcala = _girilenler.split(' ');
                List<int> gonderilenler = new List<int>();

                for (int i = 0; i < 6; i++)
                {
                    gonderilenler.Add(Convert.ToInt32(_parcala[i]));
                }

                return gonderilenler;




            }







        }


  