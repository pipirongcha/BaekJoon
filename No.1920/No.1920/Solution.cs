StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
HashSet<int> set = new HashSet<int>();
int n = int.Parse(sr.ReadLine());
int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int m = int.Parse(sr.ReadLine());
int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

for (int i = 0; i < n; i++)
{
    set.Add(a[i]);
}

for(int i = 0; i < m; i++)
{
    sw.WriteLine(set.Contains(b[i]) ? 1 : 0);
}

sw.Flush();
