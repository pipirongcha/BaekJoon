StreamReader sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
int[] dp = new int[10001];
int[] glass = new int[n+1];
int max = 0;

for (int i = 1; i <= n; i++)
{
    glass[i] = int.Parse(sr.ReadLine());
}

dp[1] = glass[1];
if (n >= 2)
{
    dp[2] = glass[1] + glass[2];
}

for (int i = 3; i <= n; i++)
{
    dp[i] = Math.Max(dp[i - 1] ,Math.Max(dp[i - 2] + glass[i], dp[i - 3] + glass[i - 1] + glass[i]));
    Console.WriteLine(dp[i]);
}



Console.WriteLine(dp[n]);