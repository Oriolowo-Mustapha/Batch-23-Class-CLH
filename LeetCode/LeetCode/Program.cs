int[] nums = { 2, 7, 11, 15 };
int target = 9; 
int[] x = new int[2];
for (int i = 0; i < nums.Length; i++)
{
    if ((nums[i] + nums[i + 1] == target))
    {
        x[0] =  i ;
        x[1] = i + 1;
        Console.WriteLine(x[0]);
    }
}
Console.WriteLine(x);
   