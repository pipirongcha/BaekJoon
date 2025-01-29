int res;
int n;
List<int> list = new List<int>();

for (int i = 0; i < 10; i++)
{
    n = int.Parse(Console.ReadLine());
    list.Add(n%42);
}

list = list.Distinct().ToList();

Console.WriteLine(list.Count);
