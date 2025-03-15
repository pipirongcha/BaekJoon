string[] input1 = Console.ReadLine().Split();
long a1 = long.Parse(input1[0]);
long a0 = long.Parse(input1[1]);
long c = int.Parse(Console.ReadLine());
long n0 = long.Parse(Console.ReadLine());

for(long i = n0; i <= 100000; i++)
{
    long fn = (a1*i)+a0;

    if(fn>c*i)
    {
        Console.WriteLine(0);
        break;
    }
    if(i == 100000 && fn<=c*i)
    {
        Console.WriteLine(1);
    }
}
