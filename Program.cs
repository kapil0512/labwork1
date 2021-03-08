using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labwork1;

namespace Lab1Q2
{
    class Program
    {

        static void Main(string[] args)
        {
            Arithmetic Art = new Arithmetic();
            Console.WriteLine("Enter First Number :-");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number :-");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");
            Console.WriteLine(" Enter 1 for ADDITION \n Enter 2 for SUBTRACTION \n Enter 3 for MULTIPLICATION \n ENTER 4 for DIVISION \n ENTER 5 for MODULUS \n ENTER 6 for exit");
            Console.WriteLine("-----------------");
            int no = int.Parse(Console.ReadLine());
              
            switch (no)
            {
                case 1:
                    Console.WriteLine("Addition is :-",Art.Add(first, second));
                    break;

                case 2:
                    Console.WriteLine("Subtraction is :-"Art.Sub(first, second));
                    break;

                case 3:
                    Console.WriteLine("Multiplication is :-"Art.Multi(first, second));
                    break;

                case 4:
                    Console.WriteLine("Division is :-"Art.Divd(first, second));
                    break;

                case 5:
                    Console.WriteLine("Modulus is :-"Art.Mod(first, second));
                    break;

                case 6:
                    Console.WriteLine("You selected exit");
                    break;
            }
            Console.ReadKey();

        }
        
    }
}
