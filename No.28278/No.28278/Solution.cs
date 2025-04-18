StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
List<int> stack = new List<int>();

void Push(int a)
{
    stack.Add(a);
}

void Pop()
{
    if (stack.Count > 0)
    {
        sw.WriteLine(stack[stack.Count-1]);
        stack.RemoveAt(stack.Count-1);
    }
    else
    {
        sw.WriteLine(-1);
    }
}

void Count()
{
    sw.WriteLine(stack.Count);
}

void EmptyCheck()
{
    if (stack.Count > 0)
    {
        sw.WriteLine(0);
    }
    else
    {
        sw.WriteLine(1);
    }
}

void Print()
{
    if (stack.Count > 0)
    {
        sw.WriteLine(stack[stack.Count-1]);
    }
    else
    {
        sw.WriteLine(-1);
    }

}

int n = int.Parse(sr.ReadLine());
for (int i = 0; i < n; i++)
{
    int[] target = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    if (target[0] == 1)
    {
        Push(target[1]);
    }
    else if (target[0] == 2)
    {
        Pop();
    }
    else if (target[0] == 3)
    {
        Count();
    }
    else if (target[0] == 4)
    {
        EmptyCheck();
    }
    else
    {
        Print();
    }
}
sw.Flush();

