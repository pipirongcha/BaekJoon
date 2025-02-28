int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();
int res = 0;

for (int i = 0; i < n; i++)
{
    int target = int.Parse(input[i]);
    int j = 1;
    while(j <= target)
    {
        if(target%j == 0)
        {
            if (j == 1 || j == i)
            {
                j++;
            }
            else
            {
                break;
            }
        }
        else
        {
            j++;
        }
    }
    if (j==target)
    {
        res++;
    }
    j = 0;
}

Console.WriteLine(res);