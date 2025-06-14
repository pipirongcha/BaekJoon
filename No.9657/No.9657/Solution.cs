int n = int.Parse(Console.ReadLine());
bool[] dp = new bool[1001];

dp[1] = true;
dp[2] = false;
dp[3] = true;
dp[4] = true;
dp[5] = true;

for(int i = 6; i <= n; i++)
{
    dp[i] = !(dp[i - 1] && dp[i - 3] && dp[i - 4]);
}

Console.Write(dp[n] ? "SK" : "CY");