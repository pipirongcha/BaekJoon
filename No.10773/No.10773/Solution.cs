StreamReader sr = new StreamReader(Console.OpenStandardInput());
int k = int.Parse(sr.ReadLine());
Stack<int> stack = new Stack<int>();
int res = 0;

for (int i = 0; i < k; i++)
{
    int input = int.Parse(sr.ReadLine());
    if (input == 0)
    {
        int tmp = stack.Pop();
        res -= tmp;
    }
    else
    {
        stack.Push(input);
        res += input;
    }
}

Console.Write(res);