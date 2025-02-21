int n = int.Parse(Console.ReadLine());
int res = 2;
for (int i = 0; i < n; i++)
{
    res = (res * 2 - 1);

}

Console.WriteLine(res*res);