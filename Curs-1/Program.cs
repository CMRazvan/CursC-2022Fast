using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadLine(); - asa citi de la tastatura
            //Console.WriteLine(); - asa afisam ce avem de afisat , mesaje variabile etc.
            // int x; - declararea variabilei (int - pentru numere, var - pentru text)
            // int x = 3; declarare variabilei cu atribuirea de valoare
            // x = 3; atribuirea de valoare variabilei


            Console.WriteLine("Hello World!");

            var x = 3;
            var y = 2;

            int latime;

            int p = x + y;

            Console.WriteLine(p);


            latime = int.Parse(Console.ReadLine());


        }
    }
}
