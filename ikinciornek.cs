using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam;
            Console.Write("İlk Değeri Giriniz=");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("İkinci Değeri Giriniz=");
            b = Int32.Parse(Console.ReadLine());

            toplam = a + b;

            Console.WriteLine();

            Console.WriteLine("Sayıların Toplamı="+toplam);
            Console.ReadKey();
            

            
        }
    }
}
