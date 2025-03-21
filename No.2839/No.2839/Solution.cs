int n = int.Parse(Console.ReadLine());
int res = -1;

for (int i = n / 5; i >= 0; i--)
{
    int tmp = n -(5*i);
    if (tmp % 3 == 0)
    {
        int a = i + (tmp / 3);
        res = a;
        break;
    }
}
Console.WriteLine(res);