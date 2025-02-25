string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);
List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    if (n%(n-i) == 0)
    {
        list.Add(n-i);
    }
}

if (list.Count >= k)
{
    Console.WriteLine(list[list.Count-k]);
}
else
{
    Console.WriteLine(0);
}