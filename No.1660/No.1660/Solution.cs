int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
int a = 1;
int b = 1;

while (b <= n)
{
    list.Add(b);
    a++;
    b += a * (a + 1) / 2;
}

int[] dp = new int[n+1];
Array.Fill(dp, int.MaxValue);
dp[0] = 0;

for (int i = 1; i <= n; i++)
{
    foreach (int j in list)
    {
        if (j > i)
        {
            break;
        }
        dp[i] = Math.Min(dp[i], dp[i - j] + 1);
    }
}

Console.WriteLine(dp[n]);