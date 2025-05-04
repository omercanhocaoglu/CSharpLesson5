using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadLine();
        }
        public static void Test()
        {
            Console.Write("Bir sayı yazınız= "); // sadece write ı kullandığımız için ikisi de aynı satırda gözükecek
            int number = int.Parse(Console.ReadLine()); // console her zaman string okur o yüzden int yazdırırken böyle kullanmalıyız
            for (int i = 0; i < number; i++)
            {
                if ( i%2 == 1 ) // böyle tek sayı halinde alacağız
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
