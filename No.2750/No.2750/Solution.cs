int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    list.Add(input);
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < list.Count; j++)
    {
        if (list[i] < list[j])
        {
            int tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }
    }
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(list[i]);
}