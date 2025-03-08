string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);
int max = a;

while (a != 0 && b != 0 && c != 0)
{
    if (max < b) {  max = b; }
    if (max < c) {  max = c; }

    if (max == a && b + c <= a)
    {
        Console.WriteLine("Invalid");
    }
    else if (max == b && a + c <= b)
    {
        Console.WriteLine("Invalid");
    }
    else if (max == c && a + b <= c)
    {
        Console.WriteLine("Invalid");
    }
    else
    {
        if (a == b && b == c)
        {
            Console.WriteLine("Equilateral");
        }
        else if (a == b || b == c || c == a)
        {
            Console.WriteLine("Isosceles");
        }
        else if (a != b && b != c)
        {
            Console.WriteLine("Scalene");
        }
    }
   


    input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    c = int.Parse(input[2]);
    max = a;
}