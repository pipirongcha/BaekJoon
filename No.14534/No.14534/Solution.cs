using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int t = int.Parse(sr.ReadLine());

for(int i = 1; i <= t; i++)
{
    string input = sr.ReadLine();
    int n = input.Length;
    char[] arr = new char[n];
    bool[] visit = new bool[n];
    sb.Append($"Case # {i}:");
    sb.AppendLine();
    Permutation(input, n, arr, visit, 0);
}

sw.Write(sb.ToString());
sw.Flush();

void Permutation(string input, int n, char[] arr, bool[] visit, int depth)
{
    if(depth == n)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            sb.Append(arr[i]);
        }
        sb.AppendLine();
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (!visit[i])
        {
            visit[i] = true;
            arr[depth] = input[i];
            Permutation(input, n, arr, visit, depth + 1);
            visit[i] = false;

        }
    }

}