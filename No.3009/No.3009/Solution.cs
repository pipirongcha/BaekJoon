using System.Text;

string[] a = Console.ReadLine().Split();
string[] b = Console.ReadLine().Split();
string[] c = Console.ReadLine().Split();

StringBuilder res = new StringBuilder();

if (a[0] == b[0])
{
    res.Append(c[0]);
}
else if (a[0] == c[0])
{
    res.Append(b[0]);
}
else
{
    res.Append(a[0]);
}

res.Append(" ");
if (a[1] == b[1])
{
    res.Append(c[1]);
}
else if (a[1] == c[1])
{
    res.Append(b[1]);
}
else
{
    res.Append(a[1]);
}

Console.WriteLine(res.ToString());