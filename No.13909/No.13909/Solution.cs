int n = int.Parse(Console.ReadLine());
int count = 1;
for (int i = 2; i < n; i++)
{
    if (i * i <= n) count++;
    else break;

}

Console.WriteLine(count);