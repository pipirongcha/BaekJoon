string inputs = Console.ReadLine();
string[] input = inputs.Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

while (true)
{
    Console.WriteLine($"{a + b}");
    inputs = Console.ReadLine();
    if (inputs != null)
    {
        input = inputs.Split();
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
    }
    else
    {
        break;
    }

}