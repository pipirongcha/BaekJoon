int n = int.Parse(Console.ReadLine());
int[] dp = new int[100001];
int m = 100001;
Array.Fill(dp, m);

dp[1] = m;
dp[2] = 1;
dp[3] = m;
dp[4] = 2;
dp[5] = 1;

for(int i = 6; i <= n; i++)
{
    if (dp[i - 5] != m || dp[i - 2] != m)
    {
        dp[i] = Math.Min(dp[i-5] + 1 , dp[i-2] + 1);
    }

}

Console.Write(dp[n] == m ? -1 : dp[n]);