int t = int.Parse(Console.ReadLine());


for (int i = 1; i <= t; i++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = a + b;
    Console.WriteLine("Case #"+i+": " + c);

}
