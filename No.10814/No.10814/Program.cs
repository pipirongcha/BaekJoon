StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());

string[][] list = new string[n][];
for (int i = 0; i < n; i++)
{
    string[] input = sr.ReadLine().Split();
    input = input.Append(i.ToString()).ToArray();
    list[i] = input;

}

Array.Sort(list, (a, b) =>
{
    int n = int.Parse(a[2]);
    int m = int.Parse(b[2]);
    int l = int.Parse(a[0]);
    int k = int.Parse(b[0]);
    if (l == k)
    {
        return n.CompareTo(m);
    }
    return l.CompareTo(k);
});

for (int i = 0;i < n; i++)
{
    sw.WriteLine($"{list[i][0]} {list[i][1]}");
}

sw.Flush();