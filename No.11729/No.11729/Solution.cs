StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
sw.WriteLine(Math.Pow(2,n)-1);

Hanoi(n, 1, 2, 3);

void Hanoi(int n, int dest, int transit ,int arr)
{
    if (n == 1)
    {
        sw.WriteLine($"{dest} {arr}");
        return;
    }
    Hanoi(n-1, dest, arr, transit);
    sw.WriteLine($"{dest} {arr}");
    Hanoi(n-1, transit, dest, arr);
}

sw.Flush();