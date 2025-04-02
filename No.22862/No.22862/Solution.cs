int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = nk[0];
int k = nk[1];
int even = 0;
int tmpEven = 0;
int SaveIdx = 0;
int FindIdx = 0;
int odd = 0;
int res = 0;

if (k > n)
{
    k = n;
}

int[] list = new int[n];


for (int i = 0; i < n; i++)
{
    if (odd == k && nums[i] % 2 != 0)
    {
        res = Math.Max(res, even);
        even -= list[FindIdx];
        odd--;
        FindIdx++;
    }

    if (nums[i] % 2 == 0)
    {
        even++;
        tmpEven++;
    }

    else
    {
        odd++;
        list[SaveIdx] = tmpEven;
        tmpEven = 0;
        SaveIdx++;
    }
}

Console.WriteLine(Math.Max(res, even));