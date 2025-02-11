string input = Console.ReadLine();
int res = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'c' && i + 1 < input.Length && input[i + 1] == '=')
    {
        i++;
        res++;
    }
    else if (input[i] == 'c' && i + 1 < input.Length && input[i + 1] == '-')
    {
        i++;
        res++;
    }

    else if (input[i] == 'd' && i + 2 < input.Length && input[i + 1] == 'z' && input[i + 2] == '=')
    {
        i += 2;
        res++;
    }
    else if (input[i] == 'd' && i + 1 < input.Length && input[i + 1] == '-')
    {
        i++;
        res++;
    }

    else if (input[i] == 'l' && i + 1 < input.Length && input[i + 1] == 'j')
    {
        i++;
        res++;
    }
    else if (input[i] == 'n' && i + 1 < input.Length && input[i + 1] == 'j')
    {

        i++;
        res++;

    }
    else if (input[i] == 's' && i + 1 < input.Length && input[i + 1] == '=')
    {
        i++;
        res++;
    }
    else if (input[i] == 'z' && i + 1 < input.Length && input[i + 1] == '=')
    {
        i++;
        res++;

    }
    else
    {
        res++;
    }
}

Console.Write(res);