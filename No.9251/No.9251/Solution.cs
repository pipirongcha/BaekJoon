string inputA = Console.ReadLine();
string inputB = Console.ReadLine();
int n = inputA.Length;
int m = inputB.Length;
int[,] dp = new int[n+1, m+1];


for (int i = 1; i <= n; i++)
{
    for(int j = 1; j <= m; j++)
    {
        if (inputA[i-1] == inputB[j-1])
        {
            dp[i,j] = dp[i-1,j-1]+1;  
        }
        else
        {
            dp[i,j] = Math.Max(dp[i-1,j], dp[i,j-1]);   
        }
    }
}

Console.WriteLine(dp[n,m]);