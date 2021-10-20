using System;

namespace Homework._4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            
        }
        static void Intro()
        {
            Console.WriteLine("Please choose the figure!");
            Console.WriteLine("");
            Console.WriteLine("To make the choice press 1, 2 or 3!");
            Console.WriteLine("");
            Console.WriteLine("The options:");
            Console.WriteLine("1. Square ");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Exit");
            Console.WriteLine("");
            int option = Convert.ToInt32(Console.ReadLine());

           

                switch (option)
                {
                    case 1:
                        Square();

                        break;
                    case 2:
                        Circle();
                        break;
                    case 3:
                        Exit();
                        break;
                }
            
            static void Square()
            {
                Console.WriteLine("You have chosen the Square!");
                Console.WriteLine("Let's calculate the area of your square");
                Console.WriteLine("");
                Console.WriteLine("Enter the side lenght of your square:  ");
                decimal side = Convert.ToDecimal(Console.ReadLine());
                decimal result_square = side * side;
                Console.WriteLine("");
                Console.WriteLine("The area of your square is: " + result_square);
                Console.ReadKey();

                Intro();
            }
        }
        static void Circle()
        {
            Console.WriteLine("You have chosen the Circle!");
            Console.WriteLine("Let's calculate the area of your circle");
            Console.WriteLine("");
            Console.WriteLine("Enter the radius of your circle:  ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double PI = Math.PI;
            double formula_circle = PI * radius * radius;
            double result_circle = Math.Round(formula_circle, 2);
            Console.WriteLine("");
            Console.WriteLine("The area of your circle is: " + result_circle);
            Console.ReadKey();

            Intro();
           }
        static void Exit()
        {
            Console.WriteLine("Bye! Have a good day! :)");
            Console.ReadKey();

        }
    }
}

