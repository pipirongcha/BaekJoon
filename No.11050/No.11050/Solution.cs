int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0];
int k = input[1];
int m = n - k;
int a = 1;
int b = 1;
int c = 1;

for (int i = 1; i <= n; i++)
{
    a *= i;
    if (i <= k)
    {
        b *= i;
    }
    if (i <= m)
    {
        c *= i;
    }
}

Console.Write(a / (b * c));
