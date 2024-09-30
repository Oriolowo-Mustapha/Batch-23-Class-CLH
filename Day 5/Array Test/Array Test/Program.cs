//int[,] multArray = new int[4, 5];
//for (int i = 0; i <= multArray.GetLength(0) - 1; i++)
//{
//    for (int j = 0; j <= multArray.GetLength(1) - 1; j++)
//    {
//        Console.WriteLine($"Enter Number {i+1},{j+1} for: ");
//        multArray[i, j] = int.Parse(Console.ReadLine());
//        Console.WriteLine(multArray[i,j]);

//    }
//    Console.WriteLine();
//}

//int[,] multArray = new int[2, 2];
//int add1 = 0;
//int add2 = 0;
//int sub = 0;
//for (int i = 0; i <= multArray.GetLength(0)-1; i++)
//{
//    for (int j = 0; j <= multArray.GetLength(1)-1; j++)
//    {
//        Console.WriteLine($"Enter Number {i+1},{j+1} for: ");
//        multArray[i, j] = int.Parse(Console.ReadLine());
//    }
//}
//add1 = multArray[0, 0] * multArray[1, 1];
//add2 = multArray[0, 1] * multArray[1, 0];
//sub = add1 - add2;
//Console.WriteLine($"Determinant of matrix multArray is {sub}");

// get an array of howmany input u want to input enter all the values
Console.WriteLine("Enter the Lenght of your array: ");
int num = int.Parse(Console.ReadLine());
int even = 0;
int odd = 0;
int addEven = 0;
int addOdd = 0;
int[] array = new int[num];

for (int i = 0; i <= array.Length-1; i++)
{
    Console.WriteLine($"Enter num {i+1}");
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] % 2 == 0)
    {
        addEven += array[i];
        even += 1;
    }
    else
    {
        addOdd += array[i]; 
        odd += 1;
    }
}
Console.WriteLine($"You have entered {even} even numbers and {odd} odd numbers.");
Console.WriteLine($"The sum of all the even number in the array is {addEven}");
Console.WriteLine($"The sum of all the odd number in the array is {addOdd}");