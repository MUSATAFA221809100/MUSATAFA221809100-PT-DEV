
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_Oyunu__Tutulan_Sayıyı_Bilgisayar_Bulacak_
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    int min = 0, max = 100, tahmin, sayac = 1;  // int değerlerini  min=sıfır  max=100 tahmine ve sayac1 olacak şekilde
                    char cevap;
                    Random rnd = new Random(); //randomı taımlıyoruz ve eni random alacak her randomlandığnda
                    while (true)//while döngü true ise
                    {
                        Console.Clear();
                        tahmin = rnd.Next((min + 1), max); //tahmin değikenini rdmyapara.next(mini +1 yaparak),max bulacak
                        //if (sayac == 1)
                        //    tahmin = 50;
                        Console.WriteLine("Tahminim  " + tahmin); //ekrana tahminm yazacak  10 
                        Console.WriteLine("Tahminim Aklındaki Sayıdan Büyükse (b)"); //ekrana sonucu Tahminim Aklındaki Sayıdan Büyükse yazacak 
                        Console.WriteLine("Tahminim Aklındaki Sayıdan Küçükse (k)");// ekranaTahminim Aklındaki Sayıdan Küçükse yazara
                        Console.WriteLine("Tahminim Doğruysa (e)");// ekrana Tahminim Doğruysa yazar
                         
                        while (true) //while döngü true ise
                        {
                            cevap = Console.ReadKey().KeyChar;
                            if (cevap == 'e' || cevap == 'b' || cevap == 'k')
                            {
                                break;// döngüyü bıraktırıoruz
                            }          Console.Clear();
          
                            Console.WriteLine("  Lütfen yönlendirmeyi yapın düzgün yapın!");//ekrana Lütfen yönlendirmeyi yapın düzgün yapın!yazar
                        }

                        if (cevap == 'e')
                        {
                            break;// döngüyü bıraktırıoruz
                        }
                        else if (cevap == 'b')
                        {
                            max = tahmin;// max tahmini işler
                        }

                        else if (cevap == 'k')
                        {
                            min = tahmin; //min tamini işler
                        }
                        sayac++;//sayaci birer birer arttıracak
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sonucu buldum. Tuttuğun Sayı : " + tahmin);//ekrana Sonucu buldum. Tuttuğun Sayı : yazacak
                    Console.WriteLine("Tahmin Sayısı : " + sayac);//Tahmin Sayısınıda yazacak
                }
                catch
                {
                    Console.WriteLine("Yanlış Yönlendirme Yaptınız!!!");//ekrana Yanlış Yönlendirme Yaptınız!!! diyecek
                }
                finally
                {
                    Console.ReadKey();
                }

            }
        }
    }
}