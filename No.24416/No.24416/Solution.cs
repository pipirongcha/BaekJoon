int n = int.Parse(Console.ReadLine());
int[] f = new int[n];
int dp = 0;
long reculsive = 0;
f[0] = 1;
f[1] = 1;
for (int i = 2; i < n; i++)
{
    dp++;
    f[i] = f[i - 1] + f[i - 2];
}
Fib(n);
int Fib(int n)
{
    if (n == 1 || n == 2)
    {
        reculsive++;
        return 1;
    }
    return (Fib(n - 1) + Fib(n - 2));
}
Console.WriteLine($"{reculsive} {dp}");