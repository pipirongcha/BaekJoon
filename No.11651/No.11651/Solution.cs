StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[][] nums = new int[n][];

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    nums[i] = input;
}

Array.Sort(nums, (a, b) =>
{
    if (a[1] == b[1])
        return a[0].CompareTo(b[0]);
    return a[1].CompareTo(b[1]);
});

for (int i = 0; i < n; i++)
{
    sw.WriteLine($"{nums[i][0]} {nums[i][1]}");
}

sw.Flush();