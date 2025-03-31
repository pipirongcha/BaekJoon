StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
Dictionary<int, int> dict = new Dictionary<int, int>();

int n = int.Parse(sr.ReadLine());
int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] sortedNums = new int[n];

for (int i = 0; i < n; i++)
{
    sortedNums[i] = nums[i];
}

Array.Sort(sortedNums);
sortedNums = sortedNums.Distinct().ToArray();

for (int i = 0; i < sortedNums.Length; i++)
{
    dict[sortedNums[i]] = i;
}

for (int i = 0; i < n; i++)
{
    nums[i] = dict[nums[i]];
    sw.Write(nums[i] + " ");
}

sw.Flush();