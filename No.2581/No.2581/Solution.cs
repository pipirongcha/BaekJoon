int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int sum = 0;
int min = 10000;

for (int i = m; i <= n; i++)
{
    int j = 2;
    while (j < i)
    {
        if (i % j == 0)
        {
            if (j != 1 && j != i)
            {
                break;
            }
            j++;
        }
        else 
        {
            j++; 
        }

    }
    if (j == i)
    {
        sum += j;
        if (j < min)
        {
            min = j;
        }
    }
    j = 2;
}

if (sum != 0)
{
    Console.WriteLine(sum);
    Console.WriteLine(min);
}
else { Console.WriteLine(-1); }