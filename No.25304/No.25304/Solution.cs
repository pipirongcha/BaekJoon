int totalCost = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int result = 0;

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    result += int.Parse(input[0]) * int.Parse(input[1]);
}
if (result == totalCost)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}