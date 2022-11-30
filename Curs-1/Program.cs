using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadLine(); - asa citi de la tastatura
            //Console.WriteLine(); - asa afisam ce avem de afisat , mesaje variabile etc.
            // int x; - definirea variabilei (int - pentru numere, var - pentru text)
            // int x = 3; declarare variabilei cu atribuirea de valoare
            // x = 3; atribuirea de valoare variabilei

            //devinirea aloca memorie
            //declararea nu aloca memorie
            /* Asa se poate comenta un text sau o zona v1.*/
            // Asa se poate comenta un text sau o zona v2. 


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
