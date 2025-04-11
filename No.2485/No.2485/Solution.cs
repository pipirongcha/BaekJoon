StreamReader sr = new StreamReader(Console.OpenStandardInput());
int total = 0; //빈 간격 더한 값
int gcd = 0;
int min = 1000000000;
int n = int.Parse(sr.ReadLine());
int[] nums = new int[n];
int[] distance = new int[n-1];

for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(sr.ReadLine());
    if (i != 0)
    {
        distance[i - 1] = nums[i] - nums[i - 1];
        if (distance[i - 1] < min)
        {
            min = distance[i - 1];
        }
    }
}

for (int i = 0; i < n-1; i++)
{
    if (i == 0)
    {
        int a = Math.Max(distance[i], distance[i + 1]);
        int b = Math.Min(distance[i], distance[i + 1]);
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        gcd = a;
    }
    else
    {
        int a = Math.Max(gcd, distance[i]);
        int b = Math.Min(gcd, distance[i]);
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        gcd = a;
    }
}

//for (int i = 0; i < n-1; i++)
//{
//    distance[i] -= gcd;
//    total += distance[i];
//} 

//Console.WriteLine(total / gcd);

Console.Write((nums[n - 1] - nums[0]) / gcd + 1 - n);