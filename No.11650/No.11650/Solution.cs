StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[][] nums = new int[n][];

for(int i=0; i<n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    nums[i] = input;
}

//for (int i = 0; i < n-1; i++)
//{
//   for (int j = 0; j < n-1-i; j++)
//   {
//        int x = nums[j][0];
//        int y = nums[j][1];
//        int tmpX = nums[j + 1][0];
//        int tmpY = nums[j + 1][1];
//        if (tmpX < x)
//        {
//            nums[j+1][0] = x;
//            nums[j+1][1] = y;
//            nums[j][0] = tmpX;
//            nums[j][1] = tmpY;
//        }
//        else if (tmpX == x && tmpY < y)
//        {
//            nums[j + 1][1] = y;
//            nums[j][1] = tmpY;
//        }
//   }
//}

Array.Sort(nums, (a, b) =>
{
    if (a[0] == b[0])
        return a[1].CompareTo(b[1]);
    return a[0].CompareTo(b[0]);
});

for (int i = 0;i < n;i++)
{
    sw.WriteLine($"{nums[i][0]} {nums[i][1]}");
}

sw.Flush();