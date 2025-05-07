int n = int.Parse(Console.ReadLine());

int Fibonacci(int x)
{
    if (x <= 1)
    {
        return x;
    }

    return Fibonacci(x - 1) + Fibonacci(x - 2);
}

Console.WriteLine(Fibonacci(n));