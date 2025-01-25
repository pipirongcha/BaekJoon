int n = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Split();

int min = 1000000;
int max = -1000000;

for  (int i = 0; i < n; i++)
{
    int target = int.Parse(nums[i]);
    if (target < min) min = target;
    if (target > max) max = target;
}

Console.WriteLine($"{min} {max}");