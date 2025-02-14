int max = 0;
int maxN = 0;
int maxM = 0;
for (int i = 0; i < 9; i++)
{
    string[] input = Console.ReadLine().Split();
    for (int j = 0; j < 9; j++)
    {
        int val = int.Parse(input[j]);

        if (max < val)
        {
            max = val;
            maxN = i;
            maxM = j;
        }
            
    }
}

Console.WriteLine(max);
Console.WriteLine($"{maxN+1} {maxM+1}");