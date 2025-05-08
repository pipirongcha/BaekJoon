using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder s = new StringBuilder();
string input = sr.ReadLine();

while (input != null)
{
    double n = double.Parse(input);
    s.Append('-', (int)Math.Pow(3, n));
    Cantor(s,0,s.Length);
    sw.WriteLine(s);
    s.Clear();
    input = sr.ReadLine();
}

sw.Flush();

void Cantor(StringBuilder s, int left, int right)
{
    int range = (right - left) / 3;
    if (range <= 0)
    {
        return;
    }

    Cantor(s, left, left+range);
    Cantor(s, left+(range*2), right);
    Merge(s, left, range, right);
}

void Merge(StringBuilder s, int left, int range, int right)
{
    int tmp = left + range;
    for (int i = 0; i < range; i++)
    {
        s[tmp] = ' ';
        tmp++;
    }
}