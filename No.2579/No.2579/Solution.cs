StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
if (n == 1)
{
    Console.Write(sr.ReadLine());
}
else if (n == 2)
{
    Console.Write(int.Parse(sr.ReadLine()) + int.Parse(sr.ReadLine()));
}
else
{
    int[] score = new int[n];
    int[] dp = new int[n];

    for (int i = 0; i < n; i++)
    {
        score[i] = int.Parse(sr.ReadLine());
    }

    dp[0] = score[0]; //1st stair
    dp[1] = score[0] + score[1]; //2nd stair
    dp[2] = Math.Max(score[0] + score[2], score[1] + score[2]); //best score of 3rd stair

    for (int i = 3; i < n; i++)
    {
        dp[i] = Math.Max(dp[i - 2] + score[i], dp[i - 3] + score[i - 1] + score[i]);
    }

    Console.Write(dp[n - 1]);
}