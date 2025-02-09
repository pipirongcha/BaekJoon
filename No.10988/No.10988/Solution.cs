char[] input = Console.ReadLine().ToCharArray();
int front = 0;
int terminal = input.Length - 1;
int res = 0;


if(front == terminal)
{
    res = 1;
    Console.WriteLine(res);
}

else if (input.Length % 2 != 0)
{
    while (terminal != front)
    {
        if (input[front] == input[terminal])
        {
            front++;
            terminal--;
            res = 1;
        }
        else
        {
            res = 0;
            break;
        }

    }
    Console.WriteLine(res);
}

else
{
    while (terminal > front)
    {
        if (input[front] == input[terminal])
        {
            front++;
            terminal--;
            res = 1;
        }
        else
        {
            res = 0;
            break;
        }

    }
    Console.WriteLine(res);
}