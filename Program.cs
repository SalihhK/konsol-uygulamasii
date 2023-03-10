using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunkenar, kısakenar, cevre, alan; // kullanılacak degiskenler tanimlandi

            Console.WriteLine("uzun kenarı giriniz :"); //bizden istenileni ekrana yazdırdık
           uzunkenar= Convert.ToInt32(Console.ReadLine());// girilen degeri uzunkenar degiskenine aktardik

            Console.WriteLine("kısa kenarı giriniz:");// istenileni ekrana yazdırdık
            kısakenar= Convert.ToInt32(Console.ReadLine());//girilen degeri kısakenar degiskenine aktardik

            cevre = 2 * (uzunkenar + kısakenar);//cevre formülünü acikladik
            Console.WriteLine("cevre:"+cevre.ToString()); //cevre icin olusan degeri ekrana yazdirdik

            alan = kısakenar * uzunkenar;//alan formülünü acıkladik
            Console.WriteLine("alan:"+alan.ToString());//alan icin olusan degeri ekrana yazdirdik






            Console.ReadKey();
        }
    }
}
