StreamReader sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
int[,] arr = new int[n,2];
int[] dp = new int[n];
for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    arr[i,0] = input[0];
    arr[i,1] = input[1];
}

var sorted = Enumerable.Range(0, n)
    .Select(i => new Tuple<int, int>(arr[i, 0], arr[i, 1]))
    .OrderBy(t => t.Item1)
    .ToArray();

for (int i = 0;i < n; i++)
{
    dp[i] = 1;
    
    for(int j = 0; j < i; j++)
    {
        if (sorted[i].Item2 > sorted[j].Item2)
        {
            dp[i] = Math.Max(dp[i], dp[j]+1);
        }
    }
}

Console.WriteLine(n - dp.Max());