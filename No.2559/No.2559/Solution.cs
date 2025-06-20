int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nk[0];
int k = nk[1];
int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int max = 0;


for(int i = 0; i < k; i++)
{
    max += input[i];
}

int tmp = max;

for (int i = k; i < n; i++)
{
    tmp = tmp + input[i] - input[i - k];
    max = Math.Max(max, tmp);
}

Console.WriteLine(max);