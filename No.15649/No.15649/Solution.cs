using System.Buffers;
using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0];
int m = input[1];

int[] nums = new int[m];
bool[] list = new bool[n];

Permutation(n, m, 0);

void Permutation(int n, int m, int l)
{
    if(m == l)
    {
        for(int i = 0; i < m; i++)
        {
            sb.Append(nums[i]+" ");
        }
        sw.WriteLine(sb.ToString());
        sb.Clear();
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (!list[i])
        {
            nums[l] = i + 1;
            list[i] = true;
            Permutation(n, m, l + 1);

            list[i] = false;
        }
    }
}

sw.Flush();
