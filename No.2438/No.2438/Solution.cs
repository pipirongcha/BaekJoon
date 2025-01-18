using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder star = new StringBuilder();
for (int i = 1; i <= n; i++)
{
    star.Append("*");
    Console.WriteLine(star);
}