int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split();

    Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
}