

string[] inputs = Console.ReadLine().Split();

List<int> nums = new List<int>();
List<int> set = new List<int>();
int numsVals = 0;
int setVals = 0;

for (int i = 0; i < inputs.Length; i++)
{
    nums.Add(int.Parse(inputs[i]));
    numsVals += nums[i];
}

for (int i = 0; i < nums.Count; i++)
{

    set.Add(nums[i]);
}


set = set.Distinct().ToList();

for (int i = 0; i < set.Count; i++)
{
    setVals += set[i];  
}

if (set.Count == 3)
{
    Console.WriteLine(nums.Max() * 100);
}

if (set.Count == 2)
{
    Console.WriteLine(1000 + (numsVals - setVals) * 100);
}

if (set.Count == 1)
{
    Console.WriteLine(10000 + nums[0] * 1000);
}

