int n = int.Parse(Console.ReadLine());
int num = 1;
int res = 1;
while (n > num)
{
    num += 6*res;
    res++;
}
Console.WriteLine(res);