using System.Text;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    Console.WriteLine($"{str[0]}{str[str.Length-1]}");
}