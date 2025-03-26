StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
string input = Console.ReadLine();
int n = input.Length;
List<int> nums = new List<int>();

for (int i = 0; i < n; i++)
{
    nums.Add(input[i]-48);
}

nums.Sort();

for (int i = n-1;i >= 0; i--)
{
    sw.Write(nums[i]);
}

sw.Flush();