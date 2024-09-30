for (int i = 1; i <= 5; i++)
{
    for (int j = i; j <= i + (i - 1); j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

for (int i = 5; i <= 20; i += 5)
{
    for (int j = 5; j <= i; j += 5)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

//for (int i = 12; i >= 3; i -= 3)
//{
//    for (int j = i; j >= 3; j -= 3)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}

