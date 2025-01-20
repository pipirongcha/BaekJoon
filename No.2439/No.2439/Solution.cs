using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder result = new StringBuilder();

for (int i = 0; i < n; i++)
{
    result.Append(" ");
}

for (int i = 1; i <= n; i++)
{
    result[result.Length -i] = '*';
    Console.WriteLine(result);
}

