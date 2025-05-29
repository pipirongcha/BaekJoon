StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n  = int.Parse(sr.ReadLine());
int[,] matrix = new int[n, 3];
int[,] dp = new int[n, 3];

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 0; j < 3; j++)
    {

        matrix[i,j] = input[j];
    }
}

for (int i = 0; i < 3; i++)
{
    dp[0, i] = matrix[0, i];
}

for (int i = 1; i < n; i++)
{
    dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i-1, 2]) + matrix[i, 0];
    dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i-1, 2]) + matrix[i, 1];
    dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i-1, 1]) + matrix[i, 2];
}

Console.Write(Math.Min(Math.Min(dp[n-1,0], dp[n-1,1]), dp[n-1,2]));