using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Lütfen 6 basamaklı bir sayı giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());

            int birler = sayi % 10;
            int onlar = (sayi % 100) / 10;
            int yuzler = (sayi % 1000) / 100;
            int binler = (sayi % 10000) / 1000;
            int onbinler = (sayi % 100000) / 10000;
            int yuzbinler = sayi / 100000;

            Console.WriteLine("\n{0} SAYISININ\n", sayi);
            Console.WriteLine("Birler basamağı= " + birler);
            Console.WriteLine("Onlar basamağı= " + onlar);
            Console.WriteLine("Yüzler basamağı= " + yuzler);
            Console.WriteLine("Binler basamağı= " + binler);
            Console.WriteLine("Onbinler basamağı= " + onbinler);
            Console.WriteLine("Yüzbinler basamağı= " + yuzbinler);

            int degerlertoplamı = birler + onlar + yuzler + binler + onbinler + yuzbinler;

            Console.WriteLine("{0} sayısının sayı değerleri toplamı = " + degerlertoplamı,sayi);

            Console.ReadLine();



        }
    }
}
