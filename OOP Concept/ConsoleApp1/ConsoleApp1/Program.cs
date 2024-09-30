string[] picture = { "abc", "ded" };
solution(picture);
static void solution(string[] picture)
{
    
    for (int i = 0; i < picture.Length-1; i++)
    {
        int newLenght = picture[i].Length+2;
        for (int j = 0; j < newLenght-1; j++)
        {
            if (picture[j] == ' ')
            {
                picture[j] = '*';
            }
        }
    }
}