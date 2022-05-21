using System;
using Fundamentos_DotNet_POO_PilaresPoo.src.Entities;

namespace Fundamentos_DotNet_POO_PilaresPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Fernando Di Nardo L.");
            System.Console.WriteLine();

            Knights Arus = new Knights("Arus", 23, "Knight");

            Knights Opponent = new Knights("Maleficus", 99 , "Devil");

            Ninjas Wedge = new Ninjas ("Wedge", 55, "Blue Ninja");

            Wizards Wizard = new Wizards ("Jennica", 23, "White Wizard");

            Wizards Topapa = new Wizards ("Topapa Supremo", 1000, "Black Wizard");

            Console.WriteLine(Arus);
            System.Console.WriteLine(Arus.Attack());
            System.Console.WriteLine();

            Console.WriteLine(Opponent);
            System.Console.WriteLine(Opponent.Attack());
            System.Console.WriteLine();

            Console.WriteLine(Wedge);
            System.Console.WriteLine(Wedge.Attack());
            System.Console.WriteLine();

            Console.WriteLine(Wizard);
            System.Console.WriteLine(Wizard.Attack());
            System.Console.WriteLine(Wizard.Attack(2));
            System.Console.WriteLine();

            Console.WriteLine(Topapa);
            System.Console.WriteLine(Topapa.Attack(99));
            System.Console.WriteLine();

        }
    }
}
