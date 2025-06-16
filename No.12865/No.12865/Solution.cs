StreamReader sr = new StreamReader(Console.OpenStandardInput());
int[] nk = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int n = nk[0];
int k = nk[1];
int[,] items = new int[n, 2];
int[] dp = new int[k+1];


for(int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for(int j = 0; j < 2; j++)
    {
        items[i,j] = input[j];  
    }
}

for(int i = 0; i < n; i++)
{
    int w = items[i, 0];
    int v = items[i, 1];
    for(int j = k; j >= w; j--)
    {
        dp[j] = Math.Max(dp[j], dp[j - w] + v);
    }
   
}

Console.WriteLine(dp.Max());