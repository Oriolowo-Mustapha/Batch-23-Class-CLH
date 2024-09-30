//Console.Write("Enter the number of integers u want to perform on: ");
//int integer = int.Parse(Console.ReadLine());

//int biggestNumber = int.MinValue;
//int smallestNumber = int.MaxValue;
//int totalSum = 0;
//for (int i = 1; i <= integer; i++)
//{

//    Console.Write($"Enter {i} Integer: ");
//    int no = int.Parse(Console.ReadLine());

//    if (no > biggestNumber)
//    {
//        biggestNumber = no;
//    }
//    if (no < smallestNumber)
//    {
//        smallestNumber = no;
//    }

//    totalSum += no;
//}
//Console.WriteLine($"The Biggest Number is {biggestNumber}");
//Console.WriteLine($"The Smallest Number is {smallestNumber}");
//int avg = totalSum / integer;
//Console.WriteLine($"Average: {avg}");

//Implement a program that asks auser to as a n number out of the n number determine with ones are even number and those that are odd number

//Console.Write("Enter how many number do u want to input: ");
//int input = int.Parse(Console.ReadLine());

//for (int i = 1; i <= input; i++)
//{
//    Console.Write($"Enter {i} number: ");
//    int no = int.Parse(Console.ReadLine());

//    if (no % 2 == 0)
//    {
//        Console.WriteLine("You av inputed an even number");
//    }
//    else if (no % 2 > 0) 
//    {
//        Console.WriteLine("You av inputed an odd number");
//    }

// tell ur user to enter n numbers each of the value inside the n number must be two digits determine which of the value inside the n number that its addition of the two digit is an odd number and the one that the addition is even number

//Console.Write("Enter how many number u want to perform on : ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    Console.Write($"Enter {i} number: ");
//    int prompt = int.Parse(Console.ReadLine()); 
//    if (prompt > 9)
//    {
//        int firstDigit = prompt / 10;
//        int secondDigit = prompt % 10;  

//        int result = firstDigit + secondDigit;

//        if (result % 2 == 0)
//        {
//            Console.WriteLine("The result is even.");
//        }
//        else 
//        {
//            Console.WriteLine("The result is odd.");

//        }
//    }
//    else
//    {
//        Console.WriteLine("Input a two digit number");
//        Console.Write($"Enter {i} number: ");
//        prompt = int.Parse(Console.ReadLine());
//    }
//}

//for (int row=1; row<=4; row++)
//{
//    for (int col=1;col<=4;col++)
//    {
//        Console.Write($"{1} ");

//    }
//    Console.WriteLine();
//}

int const1 = 2;
int const2 = 1;
while (const1 > 1 && const1 <= 12)
{
    while (const2 >= 1 && const2 <= 12)
    {
        Console.WriteLine($"{const1} X {const2} = {const1 * const2}\t");
        const1++;
    }
    Console.Write("");
    const2++;
}