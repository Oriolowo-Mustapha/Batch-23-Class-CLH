using System;
using System.Security.Cryptography.X509Certificates;
using static Delegate.Program.Calculator;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //GreetMe greetMe = new GreetMe();

            //MathDelegate del1 = new MathDelegate(Calculator.Addition);
            //MathDelegate del2 = new MathDelegate(Calculator.Subtraction);
            //MathDelegate del3 = new MathDelegate(calculator.Multiplication);
            //MathDelegate del4 = new MathDelegate(calculator.Division);
            //int a = 20;
            //int b = 10;


            //GreetmeDelegate gta = new GreetmeDelegate(greetMe.Greet);
            ////qgta.Invoke("Holla");
            //greetMe.CallBackGreet(gta);

            //Calculator.CallBackAddition(del1);
            //Console.WriteLine($"The Sum Of a and b is {Calculator.CallBackAddition}");

            //Calculator.CallBackSubtrction(del2);
            //Console.WriteLine($"The Difference Of a and b is {Calculator.CallBackSubtrction}");

            //calculator.CallBackMultiplication(del3);
            //Console.WriteLine($"The Product Of a and b is {calculator.CallBackMultiplication}");

            //calculator.CallBackDivision(del4);
            //Console.WriteLine($"The Divsion Of a and b is {calculator.CallBackDivision}");
            RectangleMultiCast rect = new RectangleMultiCast();
            RectangleDelegateMultiCast rectArea = new RectangleDelegateMultiCast(rect.GetArea);
            rectArea += rect.GetPerimeter;
            rectArea(23.43, 73.8);

            RectangleMultiCast2 rect2 = new RectangleMultiCast2();
            RectangleDelegateMultiCast2 deligateReturn = rect2.GetArea;
            deligateReturn += rect2.GetPerimeter;
            Console.WriteLine(deligateReturn(18,90.2));
        }
        public class GreetMe
        {
            public void Greet(string greet)
            {
                Console.WriteLine($"Hello {greet}");

            }
            public void CallBackGreet(GreetmeDelegate gra)
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                gra(name);
            }
        }
        public class Calculator
        {
            public static int Addition(int a, int b)
            {
                return a + b;

            }
            public static void CallBackAddition(MathDelegate math)
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                math(a, b);
            }


            public static int Subtraction(int a, int b) { return a - b; }
            public static void CallBackSubtrction(MathDelegate math)
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                math(a, b);
            }

            public int Multiplication(int a, int b) { return a * b; }
            public void CallBackMultiplication(MathDelegate math)
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                math(a, b);
            }

            public int Division(int a, int b) { return a / b; }
            public void CallBackDivision(MathDelegate math)
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                math(a, b);
            }

            public class RectangleMultiCast
            {
                public void GetArea(double Width, double Height)
                {
                    Console.WriteLine($"Area is {Width * Height}");
                }

                public void GetPerimeter(double Width, double Height)
                {
                    Console.WriteLine($"Perimeter is {2*(Width + Height)}");
                }
            }

            public class RectangleMultiCast2
            {
                public double GetArea(double Width, double Height)
                {
                   return Width*Height;
                }

                public double GetPerimeter(double Width, double Height)
                {
                    return Width + Height;
                }
            }


        }
       
    }
    public delegate int MathDelegate(int x, int y);
    public delegate void GreetmeDelegate(string str);
    public delegate void RectangleDelegateMultiCast(double x, double y);
    public delegate double RectangleDelegateMultiCast2(double x, double y);
}