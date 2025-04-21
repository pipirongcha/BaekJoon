StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string input = sr.ReadLine();
Stack<char> stack = new Stack<char>();
while(input != ".")
{
    bool isBalanced = true;

    for (int i = 0; i < input.Length; i++)
    {

        if (input[i] == '(')
        {
            stack.Push(input[i]);
        }
        else if (input[i] == '[')
        {
            stack.Push(input[i]);
        }
        else if (input[i] == ')')
        {
            if(stack.Count == 0 || stack.Pop() != '(')
            {
                isBalanced = false;
                break;
            }
        }
        else if (input[i] == ']')
        {
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                isBalanced = false;
                break;
            }
        }
    }
    if (stack.Count != 0)
    {
        isBalanced = false;
    }

    if (isBalanced)
    {
        sw.WriteLine("yes");
    }
    else
    {
        sw.WriteLine("no");
    }
    input = sr.ReadLine();
    stack.Clear();
}

sw.Flush();