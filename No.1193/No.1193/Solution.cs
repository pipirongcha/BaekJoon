int input = int.Parse(Console.ReadLine());

int a = 0;
int b = 0;
int max = 1;
bool asendingA = true;
bool asendingB = true;
bool running = true;

for (int i = 0; i < input; i++)
{
    if (b == max && running == false)
    {
        max++;
        a = 1;
        b = max;
        asendingA = true;
        asendingB = false;
        running = true;
    }
    else if (a == max && running == false)
    {
        max++;
        a = max;
        b = 1;
        asendingA = false;
        asendingB = true;
        running = true;
    }
    else
    {
        if (asendingA) { a++; }
        else { a--; }

        if (asendingB) { b++; }
        else { b--; }

        if (a == max || b == max)
        {
            running = false;
        }
    }
}

Console.WriteLine(a + "/" + b);
