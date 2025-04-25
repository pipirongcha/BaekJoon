StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(sr.ReadLine());

LinkedList<int> deque = new LinkedList<int>();

void Push(int x)
{
    deque.AddFirst(x);
}

void Enqueue(int x)
{
    deque.AddLast(x);
}

void Pop()
{
    if (deque.Count > 0)
    {
        sw.WriteLine(deque.First.Value);
        deque.RemoveFirst();
    }
    else
    {
        sw.WriteLine(-1);
    }
}

void Dequeue()
{
    if (deque.Count > 0)
    {
        sw.WriteLine(deque.Last.Value);
        deque.RemoveLast();
    }
    else
    {
        sw.WriteLine(-1);
    }
}

void Count()
{
    sw.WriteLine(deque.Count());
}

void isEmpty()
{
    if (deque.Count > 0)
    {
        sw.WriteLine(0);
    }
    else
    {
        sw.WriteLine(1);
    }
}

void FrontPeek()
{
    if (deque.Count > 0)
    {
        sw.WriteLine(deque.First.Value);
    }
    else
    {
        sw.WriteLine(-1);
    }
}

void TerminalPeek()
{
    if (deque.Count > 0)
    {
        sw.WriteLine(deque.Last.Value);
    }
    else
    {
        sw.WriteLine(-1);
    }

}

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    switch (input[0])
    {
        case 1:
            Push(input[1]);
            break;
        case 2:
            Enqueue(input[1]);
            break;
        case 3:
            Pop();
            break;
        case 4:
            Dequeue();
            break;
        case 5:
            Count();
            break;
        case 6:
            isEmpty();
            break;
        case 7:
            FrontPeek();
            break;
        case 8:
            TerminalPeek();
            break;
    }
}

sw.Flush();
