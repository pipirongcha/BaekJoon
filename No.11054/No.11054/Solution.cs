int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] increase = new int[n];
int[] decrease = new int[n];
int res = 0;

for (int i = 0; i < n; i++)
{
    increase[i] = 1;

    for (int j = 0; j < i; j++)
    {
        if (arr[i] > arr[j])
        {
            increase[i] = Math.Max(increase[i], increase[j] + 1);
        }
    }
}

for (int i = n - 1; i >= 0; i--)
{
    decrease[i] = 0;
    for (int j = n - 1; j > i; j--)
    {
        if (arr[i] > arr[j])
        {
            decrease[i] = Math.Max(decrease[i], decrease[j] + 1);
        }
    }
}

for (int i = 0; i < n; i++)
{
    res = Math.Max(res, increase[i] + decrease[i]);
}
Console.WriteLine(res);