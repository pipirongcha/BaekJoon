using System.Text;

int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
List<int> res = new List<int>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
{ 
    list.Add(int.Parse(Console.ReadLine()));
}

res = list.Distinct().ToList();
res.Sort();

for (int i = 0; i < res.Count; i++)
{
    sb.AppendLine(res[i].ToString());
}

Console.WriteLine(sb.ToString()); 

