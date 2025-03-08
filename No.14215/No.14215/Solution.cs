string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);  
int c = int.Parse(input[2]);

int max = a;
if (max < b) max = b;
if (max < c) max = c; 

if (a == b && b == c)
{

}
else if (max == a)
{
    if (b + c <= a)
    {
        a = (b + c) - 1;
    }
}
else if (max == b)
{
    if (a + c <= b)
    {
        b = (a + c) - 1;
    }
}
else if (max == c)
{
    if (a + b <= c)
    {
        c = (b + a) - 1;
    }
}
Console.WriteLine(a + b + c);