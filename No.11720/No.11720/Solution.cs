int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
int res = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse($"{str[i]}");
    res += num;
}
Console.WriteLine(res);