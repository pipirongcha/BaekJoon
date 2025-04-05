using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();

int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];
string[] names = new string[n + m];
int res = 0;


for (int i = 0; i < n + m; i++)
{
    names[i] = sr.ReadLine();
}

Array.Sort(names);

for (int i = 0; i < n + m - 1; i++)
{
    if (names[i] == names[i + 1])
    {
        res++;
    }
}
sb.AppendLine(res.ToString());

for (int i = 0; i < n + m - 1; i++)
{
    if (names[i] == names[i + 1])
    {
        sb.AppendLine(names[i]);
    }
}
Console.WriteLine(sb.ToString());
