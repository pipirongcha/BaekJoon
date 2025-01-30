string[] tmp = Console.ReadLine().Split();
int n = int.Parse(tmp[0]);
int m = int.Parse(tmp[1]);
int[] res = new int[n];

for (int i = 0; i < n; i++)
{
    res[i] = i + 1;
}

for (int a = 0; a < m; a++)
{
    tmp = Console.ReadLine().Split();
    int i = int.Parse(tmp[0]) - 1;
    int j = int.Parse(tmp[1]) - 1;

    while (i < j)
    {
        int tmp2 = res[i];
        res[i] = res[j];
        res[j] = tmp2;
        i++;
        j--;
    }
}

Console.WriteLine(string.Join(" ",res));
