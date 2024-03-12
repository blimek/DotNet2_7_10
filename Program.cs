
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_10

         //Napisz program, który sprawdzi, czy z 3 podanych długości można
         //stworzyć trójkąt
         //Dane testowe : 40 55 65
         //Rezultat w terminalu :
         //Można zbudować trójkąt
{
    internal class Program


    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą długość");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą długość");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią długość");
            int c = Int32.Parse(Console.ReadLine());

            if (a+b>c && a+c > b && b+c > a)
            {
                Console.WriteLine("Z tych długości można zbudować trójkąt");

            }
            else
            {
                Console.WriteLine("Z podanych długości nie można zbudować trókąta");

            }
            Console.ReadLine();



        }
    }
}
