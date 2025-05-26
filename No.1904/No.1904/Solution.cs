int n = int.Parse(Console.ReadLine());
//int[] dp = new int[n];

//dp[0] = 1;

//if (n > 1)
//{
//    dp[1] = 2;
//}
//for (int i = 2; i < n; i++)
//{
//    dp[i] = (dp[i - 2] + dp[i - 1]) % 15746;
//}

//Console.Write(dp[n - 1]);



/*
 Better Code 
 */

int a = 1;
int b = 2;
int res = 0;

if (n == 1)
{
    Console.Write(1);
}
else if (n == 2)
{
    Console.Write(2);
}
else
{
    for (int i = 0; i < n - 2; i++)
    {
        res = (a + b) % 15746;
        a = b;
        b = res;
    }

    Console.WriteLine(res);
}



