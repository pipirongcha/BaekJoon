﻿int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] dp = new int[n];

for(int i = 0; i < n; i++)
{
    dp[i] = 1;
    
    for(int j = 0; j < i; j++)
    {
        if (arr[i] > arr[j])
        {
            dp[i] = Math.Max(dp[i], dp[j]+1);
        }
    }
}

Console.WriteLine(dp.Max());