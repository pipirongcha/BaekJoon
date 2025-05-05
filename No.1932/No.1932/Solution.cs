//StreamReader sr = new StreamReader(Console.OpenStandardInput());
//int n = int.Parse(sr.ReadLine());
//int res = int.Parse(sr.ReadLine());
//int idx = 0;

//for(int i = 1; i < n; i++)
//{
//    int[] floor = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
//    int max = Math.Max(floor[idx], floor[idx + 1]);
//    res += max;
//    if (floor[idx]!= max)
//    {
//        idx++;
//    }

//}

//Console.Write(res);

/*
  Greedy Argorithm can't solve this problem
*/


StreamReader sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
int[][] triangle = new int[n][];

for (int i = 0; i < n; i++)
{
    triangle[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
}

for (int i = n-2;i >= 0; i--)
{
    for(int j = 0; j < i+1; j++)
    {
        triangle[i][j] += Math.Max(triangle[i + 1][j], triangle[i + 1][j + 1]);
    }
}

Console.Write(triangle[0][0]);
