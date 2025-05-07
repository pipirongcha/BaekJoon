long n = long.Parse(Console.ReadLine());

long Factorial(long x)
{
    if (x <= 1)
    {
        return 1;
    }

    return x * Factorial(x-1);
}

Console.WriteLine(Factorial(n));