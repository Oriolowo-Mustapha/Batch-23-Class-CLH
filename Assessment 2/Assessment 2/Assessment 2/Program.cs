// Question 1
//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"{num} * {i} = {num * i}");

//}

// Question 2
//Console.Write("Enter a digit: ");
//int digit = int.Parse(Console.ReadLine());

//Console.Write("Enter number of rows: ");
//int rows =  int.Parse(Console.ReadLine());
//for (int i = 1; i <= rows; i++)
//{
//    for (int j = 0; j < rows; j++)
//    {
//        if (i % 2 == 0)
//        {
//            Console.Write(digit);

//        }
//        else
//        {
//            Console.Write(digit + " ");

//        }
//    }
//    Console.WriteLine();
//}

//Question 3
//Console.Write("Input a string: ");
//string input = Console.ReadLine();
//char[] chars = input.ToCharArray();
//char firstChar = ' ';

//for (int i = 0; i < chars.Length; i++)
//{
//    firstChar = chars[0];
//}

//Console.WriteLine($"{firstChar}{input}{firstChar}");
// Question 4
//Console.Write("Enter number to print sequence: ");
//int num = int.Parse(Console.ReadLine());
//int[] array = new int[6];

//for (int i = 0; i < 6; i++)
//{
//    num += 6;
//    array[i] = num;
//}
//foreach (var item in array)
//{
//    Console.Write($"{item}, ");
//}

// Question 5
// static void printRange()
//{
//    Console.Write("Enter range: ");
//    int range = int.Parse(Console.ReadLine());

//    for (int i = 1; i <= range; i++)
//    {
//        if (i % 3 == 0 && i % 7 != 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//printRange();

// Question 6
//static void MulArray(int[] array1, int[] array2)
//{
//    int[] mulArray = new int[array2.Length];
//    for (int i = 0; i < array1.Length; i++)
//    {
//        mulArray[i] = array1[i] * array2[i];
//    }
//    foreach (var item in mulArray)
//    {
//        Console.Write($"{item}, ");
//    }
//}
//int[] array1 = { 1, 3, -5, 4 };
//int[] array2 = { 1, 4, -5, -2 };
//MulArray(array1, array2);

// Question 7.
//static void bonusPoint()
//{
//    Console.Write("Enter Score: ");
//    double score = double.Parse(Console.ReadLine());

//    if (score >= 1 && score <= 3)
//    {
//        score *= 10;
//        Console.WriteLine($"You got {score} points.");
//    }
//    else if (score >= 4 && score <= 6)
//    {
//        score *= 100;
//        Console.WriteLine($"You got {score} points.");
//    }
//    else if (score >= 7 && score <= 9)
//    {
//        score *= 1000;
//        Console.WriteLine($"You got {score} points.");
//    }
//    else
//    {
//        Console.WriteLine("Error. \nInvalid Input.");
//    }
//}
//bonusPoint();

//Question 8
//Console.Write("Enter Number (0-9): ");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 0:
//        Console.WriteLine("Zero.");
//        break;
//    case 1:
//        Console.WriteLine("One.");
//        break;
//    case 2:
//        Console.WriteLine("Two.");
//        break;
//    case 3:
//        Console.WriteLine("Three.");
//        break;
//    case 4:
//        Console.WriteLine("Four.");
//        break;
//    case 5:
//        Console.WriteLine("Five.");
//        break;
//    case 7:
//        Console.WriteLine("Seven.");
//        break;
//    case 8:
//        Console.WriteLine("Eight.");
//        break;
//    case 9:
//        Console.WriteLine("Nine.");
//        break;
//    default:
//        Console.WriteLine("Invalid Input.");
//        break;
//}

//// Question 9
//static void printNnumber()
//{
//    Console.Write("Enter any natural numbers: ");
//    int nNumber = int.Parse(Console.ReadLine());
//    int sum = 0;
//    string num = "";
//    for (int i = 1; i <= nNumber; i++)
//    {
//        sum += i;
//        num += i + " ";
//    }
//    Console.WriteLine($"The First {nNumber} natural numbers are: {num}");
//    Console.WriteLine($"The Sum of Natural Number upto {nNumber} terms: {sum}");
//}
//printNnumber();

//Question 10.
//static void reverseArray()
//{
//    Console.Write("Enter number of array: ");
//    int N = int.Parse(Console.ReadLine());
//    int[] array = new int[N];

//    for (int i = 0; i < N; i++)
//    {
//        Console.Write($"Enter {i + 1} Number: ");
//        int num = int.Parse(Console.ReadLine());
//        array[i] = num;
//    }

//    for (int i = array.Length; i >= 1; i--)
//    {
//        Console.Write($"{i} ");
//    }
//}
//reverseArray();

// Question 11
//Console.WriteLine("Enter Amount of Water in KG: ");
//double mass = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter Initial Temprature of the water: ");
//double initialTemp =  double.Parse(Console.ReadLine());

//Console.WriteLine("Enter Final Temprature of the water: ");
//double finalTemp = double.Parse(Console.ReadLine());

//double energy = mass * (finalTemp - initialTemp) * 4148;
//Console.WriteLine($"The Energy of mass of water {mass} which initial temprature was {initialTemp}C and final temprature was {finalTemp}C is {energy}J.");

// Question 12.
//static void SumArray()
//{
//    Console.Write("Enter number of array: ");
//    int N = int.Parse(Console.ReadLine());
//    int[] array = new int[N];
//    int sum = 0;
//    for (int i = 0; i < N; i++)
//    {
//        Console.Write($"Enter {i + 1} Number: ");
//        int num = int.Parse(Console.ReadLine());
//        array[i] = num;
//    }
//    for (int i = 0; i < array.Length; i++)
//    {
//        sum += array[i];
//    }
//    Console.WriteLine($"Sum of all elements stored int the array is: {sum}");
//}
//SumArray();

// Question 13
//Console.Write("Enter minutes to convert: ");
//double min = double.Parse(Console.ReadLine());
//double year = min / 525600;
//double day = min / 1440;

//Console.WriteLine($"{min} minutes - {year}");
//Console.WriteLine($"{min} minutes - {day}");

// Question 14
//static void duplicate()
//{
//    Console.Write("Enter number of array: ");
//    int N = int.Parse(Console.ReadLine());
//    int[] array = new int[N];
//    int count = 0;
//    for (int i = 0; i < N; i++)
//    {
//        Console.Write($"Enter {i + 1} Number: ");
//        int num = int.Parse(Console.ReadLine());
//        array[i] = num;
//    }
//    for (int i = 0; i < array.Length-1; i++)
//    {
//        if (array[i] == array[i +1])
//        {
//            count++;
//        }
//    }
//    Console.WriteLine($"Total number of duplicate elements found in the array is :{count} ");
//}
//duplicate();

// Question 15
//static void addDigit()
//{
//    Console.Write("Enter digits between 0 and 1000: ");
//    int digit = int.Parse(Console.ReadLine());

//    int lastNum = digit % 10;
//    int mid1 = digit / 10;
//    int firstNum = mid1 / 10;
//    int secondNum = mid1 % 10;
//    int add = firstNum + secondNum + lastNum;
//    Console.Write($"The sum of all its digits is {add}");
//}
//addDigit();

// Question 16
//Console.Write("Enter subtotal: ");
//double subTotal = double.Parse(Console.ReadLine());

//Console.Write("Enter gratituity rate: ");
//double grat = double.Parse(Console.ReadLine());

//double gratuity = (grat / 100) * subTotal;
//double total = gratuity + subTotal;
//Console.Write($"Gratuity = ${gratuity} \nTotal = ${total}");

// Question 17
//static void unique()
//{
//    Console.Write("Enter number of array: ");
//    int N = int.Parse(Console.ReadLine());
//    int[] array = new int[N];
//    int count = 0;
//    for (int i = 0; i < N; i++)
//    {
//        Console.Write($"Enter {i + 1} Number: ");
//        int num = int.Parse(Console.ReadLine());
//        array[i] = num;
//    }
//    for (int i = 0; i < array.Length - 1; i++)
//    {
//        if (array[i] != array[i + 1])
//        {
//            count = array[i];
//        }
//    }
//    Console.WriteLine($"The unique elements found in the array is :{count} ");
//}
//unique();

// Question 18
//static void factorial()
//{
//    Console.Write("Enter Number: ");
//    int num  = int.Parse(Console.ReadLine());
//    int factorial = 1;
//    for (int i = 1; i <= num; i++)
//    {
//        factorial *= i;
//    }
//    Console.WriteLine(factorial);
//}
//factorial();

// Question 19
//static void MaxminNum()
//{
//    Console.Write("Enter number of array: ");
//    int N = int.Parse(Console.ReadLine());
//    int[] array = new int[N];
//    int max = 0;
//    int min = int.MaxValue;
//    for (int i = 0; i < N; i++)
//    {
//        Console.Write($"Enter {i + 1} Number: ");
//        int num = int.Parse(Console.ReadLine());
//        array[i] = num;
//    }
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > max)
//        {
//            max = array[i];
//        }
//        if (array[i] < min)
//        {
//            min = array[i];
//        }
//    }
//    Console.Write($"Maximum element is : {max}\nMinimum element is : {min}");
//}
//MaxminNum();

// Question 20
//Console.Write("Enter Speed limit: ");
//int speedLimit = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter Car Speed: ");
//int carSpeed = Convert.ToInt32(Console.ReadLine());

//if (carSpeed < speedLimit)
//{
//    Console.WriteLine("Its Still Ok. \n Keep it up.");
//}
//else
//{
//    int diff = carSpeed - speedLimit;
//    int speeder = diff / 5;
//    int demritpoint = speeder;
//    if (demritpoint > 12)
//    {
//        Console.WriteLine("Licence Suspended.");
//    }
//    else
//    {
//        Console.WriteLine("Your demerit point is " + demritpoint + " pls warn ur self.");
//    }
//}

// Question 21
//Console.Write("Enter mass in pounds to convert: ");
//double pounds = double.Parse(Console.ReadLine());

//double convert = pounds * 0.454;
//Console.WriteLine($"{pounds}pounds is {convert}KG");

// Question 22
//Console.WriteLine("Enter initial velocity: ");
//double U = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter Final velocity: ");
//double V = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the total time taken: ");
//double T = double.Parse(Console.ReadLine());

//double A = (V - U) / T;
//Console.WriteLine($"The Average Acceleration is: {A}m/s");

// Question 24
//Console.Write("Enter Number (0-9): ");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 0:
//        Console.WriteLine("Zero.");
//        break;
//    case 1:
//        Console.WriteLine("One.");
//        break;
//    case 2:
//        Console.WriteLine("Two.");
//        break;
//    case 3:
//        Console.WriteLine("Three.");
//        break;
//    case 4:
//        Console.WriteLine("Four.");
//        break;
//    case 5:
//        Console.WriteLine("Five.");
//        break;
//    case 7:
//        Console.WriteLine("Seven.");
//        break;
//    case 8:
//        Console.WriteLine("Eight.");
//        break;
//    case 9:
//        Console.WriteLine("Nine.");
//        break;
//    default:
//        Console.WriteLine("Invalid Input.");
//        break;
//}

// Question 25
static void Fourdigiter()
{
    Console.WriteLine("Enter a four digit number: ");
    int num = int.Parse(Console.ReadLine());
    int lastNum = num % 10;
    int mid1 = num / 10;
    int mid2 = mid1 / 10;
    int firstNum = mid2 /10;
    int secondNUm = mid2 % 10;
    int thirdNum = mid1 % 10;
    int add = firstNum + secondNUm +thirdNum+ lastNum;
    Console.WriteLine($"{add}");
    Console.Write($"{lastNum}{thirdNum}{secondNUm}{firstNum}");
  
    
}
Fourdigiter();

