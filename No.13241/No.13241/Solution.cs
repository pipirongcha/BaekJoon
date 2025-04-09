long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long a = Math.Max(input[0], input[1]);
long b = Math.Min(input[0], input[1]);
while(b!=0)
{
    long r = a % b;
    a = b;
    b = r;
}
Console.WriteLine(input[0] * input[1] / a);