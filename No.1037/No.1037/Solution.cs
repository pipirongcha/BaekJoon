int n = int.Parse(Console.ReadLine());
int[] factors = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int min = 2147483647;
int max = 0;

for (int i = 0; i < n; i++)
{
    if (factors[i] < min)
    {
        min = factors[i];
    }
    if (factors[i] > max)
    {
        max = factors[i];
    }
}

Console.Write(min * max);