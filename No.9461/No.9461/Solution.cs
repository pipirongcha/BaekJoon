using System.Text;

StringBuilder sb = new StringBuilder();
StreamReader sr = new StreamReader(Console.OpenStandardInput());

int t = int.Parse(sr.ReadLine());

long[] p = new long[101];
p[1] = 1;
p[2] = 1;
p[3] = 1;
for (int i = 1; i < 98; i++)
{
    p[i+3] = p[i] + p[i + 1];
}

for(int i = 0;i <t;i++)
{
    sb.AppendLine(p[int.Parse(sr.ReadLine())].ToString());
}

Console.WriteLine(sb.ToString());

//Using StringBuilder was better than Using StreamWriter (Space Capacity) 