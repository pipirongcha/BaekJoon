string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

while (a != b)
{
    if (b%a == 0)
    {
        Console.WriteLine("factor");
    }
    else if(a%b == 0)
    {
        Console.WriteLine("multiple");
    }
    else
    {
        Console.WriteLine("neither");
    }
    input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
}