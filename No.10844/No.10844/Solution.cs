﻿int n = int.Parse(Console.ReadLine());
int[,] dp = new int[n+1, 10];
int res = 0;

for(int i = 1; i < 10; i++)
{
    dp[1,i] = 1;
}

for(int i = 2;i <= n; i++)
{
    for(int j = 0; j < 10; j++)
    {
        if (j == 0)
        {
            dp[i,j] = dp[i-1,1];
        }
        else if (j == 9)
        {
            dp[i,j] = dp[i-1,8];
        }
        else
        {
            dp[i,j] = (dp[i - 1,j - 1] + dp[i - 1,j + 1]) % 1000000000;
        }
    }
}

for (int i = 0; i < 10; i++)
{
    res = (res + dp[n, i]) % 1000000000;
}
Console.WriteLine(res);