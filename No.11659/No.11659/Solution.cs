StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

int[] add = new int[n];
add[0] = arr[0];
for (int i = 1; i < n; i++)
{
    add[i] = arr[i]+add[i-1];
}

for(int i = 0; i < m; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int start = input[0];
    int end = input[1];
    if (start == 1)
    {
        sw.WriteLine(add[end-1]);
    }
    else
    {
        sw.WriteLine(add[end-1] - add[start - 2]);
    }
}
sw.Flush();