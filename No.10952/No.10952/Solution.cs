string[] input = Console.ReadLine().Split();

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

while (a != 0 && b != 0)
{
    Console.WriteLine($"{a + b}");
    input = Console.ReadLine().Split(); 
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
}