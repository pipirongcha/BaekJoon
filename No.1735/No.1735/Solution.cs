int[] input1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool done = false;

int a = (input1[0] * input2[1]) + (input2[0] * input1[1]);
int b = input1[1] * input2[1];
while (!done)
{
    int tmpA = a;
    int tmpB = b;

    while (tmpB != 0)
    {
        int r = tmpA % tmpB;
        tmpA = tmpB;
        tmpB = r;
    }

    if (tmpA == 1)
    {
        done = true;
    }
    else
    {
        a = a / tmpA;
        b = b / tmpA;
    }
}
Console.WriteLine($"{a} {b}");