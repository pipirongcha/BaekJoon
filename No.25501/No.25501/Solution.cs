StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StreamReader sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
int m = 0;
for(int i = 0; i < n; i++)
{
    string s = sr.ReadLine();
    m = 0;
    Recursion(s, 0, s.Length - 1);
    sw.WriteLine($"{Recursion(s, 0, s.Length - 1)} {m/2}");
}
int Recursion(string s, int l, int r)
{
    m++;
    if (l >= r)
    {
        return 1;
    }
    else if (s[l] != s[r])
    {
        return 0;
    }
    else return Recursion(s, l + 1, r - 1);
}

sw.Flush();
