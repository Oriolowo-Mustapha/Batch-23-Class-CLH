using System;

namespace whileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;

            //while (count < 3)
            //{
            //    Console.WriteLine("My name is mustapha");
            //    count++;

            //    if (count == 3)
            //    {
            //        break;
            //    }
            //}

            //Console.Write("Enter Number N which is greater than zero --> ");
            //int number = int.Parse(Console.ReadLine());

            //int counter = 1;
            //int initailizer = 1;

            //while (counter <= number)
            //{
            //    initailizer *= counter;
            //    counter++;
            //}
            //Console.WriteLine(initailizer);

            //Console.Write("Enter a valid Number (1-10) --> ");
            //int input = int.Parse(Console.ReadLine());

            //int counter = 1;
            //while (counter < 5 )
            //{

            //    if(input > 0 && input <= 10) 
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        counter++;

            //        Console.Write("Enter a valid Number (1-10) --> ");
            //        input = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine($"Thanks for using Valid number App Your NumberOF trials remain --> {5- counter}");

            //Console.Write("Enter how many numbers you want to input: ");
            //int no = int.Parse(Console.ReadLine());

            //int counter = 0;
            //int biggerNumber = int.MinValue;
            //int smallerNumber = int.MaxValue;

            //while (counter < no)
            //{
            //    Console.Write($"Enter {counter + 1} number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number >  biggerNumber)
            //    {
            //        biggerNumber = number; 
            //    }
            //    if (number < smallerNumber)
            //    {
            //        smallerNumber = number;
            //    }
            //    counter++;

            //    if (no == counter)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"The Largest Number --> {biggerNumber}");
            //Console.WriteLine($"The Smallest Number --> {smallerNumber}");

            //Console.WriteLine("Enter Age: ");
            //int age = int.Parse(Console.ReadLine());

            //int count = 0;

            //do
            //{
            //    if (count == 0)
            //    {
            //        Console.WriteLine($"Your current age is {age}");
            //    }
            //    count++;
            //    Console.WriteLine($"Your Age in the next {age * 3} years is {age +=3}");
            //}
            //while(count < 10);

            // Print A number from 1 to 10 using for loop or give me the cubic value from 1 to 10

            //for (int i = 1; i <= 10; i++)
            //{
            //    int cube = i * i * i;
            //    Console.WriteLine($"Cube of {i} is {cube}");
            //}

            // Implement a program using for loop that print frm one to 10

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Implement a program that print your name 10 times
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Oriolowo Mustapha.");
            //}

            //Implement a program that print in a reverse order 10 to 1
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine()); 
            //for (int i = number; i >= 1; i--)
            //{
            //    Console.WriteLine(i);   
            //}

            //int count = 0;
            //int y = 1;

            //while (true)
            //{
            //    int x = 2;
            //    int counter = 1;

            //    while (y <= 12)
            //    {
            //        Console.Write($"{x} X {y} = {x*y} \t");
            //        x++;
            //        counter++;
            //    }
            //    if (counter == 12)
            //    {
            //        break;
            //    }
            //    y++;
            //    count ++;

            //    if (count == 12)
            //    {
            //        break;
            //    }
            //}

            int start = 2;
            int end = 12;

            // Outer loop for the first number
            int i = start;
            while (i <= end)
            {
                // Inner loop for the second number
                int j = 1;
                while (j <= end)
                {
                    // Print the product of i and j
                    Console.Write($"{i} X {j} = {i * j} \t");
                    j++;
                }
                // Move to the next line after each row
                Console.WriteLine();
                i++;
            }
        }
    }
}