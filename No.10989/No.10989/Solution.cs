StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int[] nums = new int[10001];

int n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    nums[int.Parse(sr.ReadLine())]++;
}

for (int i = 0; i < nums.Length; i++)
{
    while (nums[i] != 0)
    {
        sw.WriteLine(i);
        nums[i]--;
    }
}
sw.Flush();