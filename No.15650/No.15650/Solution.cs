using System.Text;

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();

int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

int n = nm[0];
int m = nm[1];
int[] arr = new int[m];


Combination(0);
sw.Write(sb.ToString());


void Combination(int depth)
{
    if (m == depth)
    {
        for (int i = 0; i < m; i++)
        {
            sb.Append(arr[i] + " ");
        }
        sb.Append("\n");
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if(depth == 0 || i+1 > arr[depth-1])
        {
            arr[depth] = i + 1;
            Combination(depth + 1);
        }
        else
        {
            continue;
        }
    }
}

sw.Flush();