using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];
int[] arr = new int[m];

Combination(0);
sw.WriteLine(sb.ToString());

void Combination(int depth)
{
    if (m == depth)
    {
        for (int i = 0; i < m; i++)
        {
            sb.Append(arr[i]+" ");
        }
        sb.Append("\n");
        return;
    }

    for (int i = 0; i < n; i++)
    {
        arr[depth] = i + 1;
        Combination(depth+1);
    }
}

sw.Flush();