int m = int.Parse(Console.ReadLine());
List<bool> list = new List<bool>();

for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        list.Add(true);
    }
    else
    {
        list.Add(false);
    }
}

for (int i = 0; i < m; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = input[0] - 1;
    int b = input[1] - 1;

    bool tmp = list[a];
    list[a] = list[b];
    list[b] = tmp;



}

for (int i = 0;i < 3; i++)
{
    if (list[i])
    {
        Console.WriteLine(i+1);
        break;
    }
}