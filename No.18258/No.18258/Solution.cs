StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
Queue<int> queue = new Queue<int>();
int terminal = 0;

void Push(int x)
{
    queue.Enqueue(x);
    terminal = x;
}

void Pop()
{
    if (queue.Count > 0)
    {
        sw.WriteLine(queue.Dequeue());
    }
    else
    {
        sw.WriteLine(-1);
    }
}
void Size()
{
    sw.WriteLine(queue.Count);
}

void Empty()
{
    if(queue.Count > 0)
    {
        sw.WriteLine(0);
    }
    else
    {
        sw.WriteLine(1);
    }
}

void Front()
{
    if(queue.Count > 0)
    {
        sw.WriteLine(queue.Peek());
    }
    else
    {
        sw.WriteLine(-1);
    }
}

void Back()
{
    if (queue.Count > 0)
    {
        sw.WriteLine(terminal);
    }
    else
    {
        sw.WriteLine(-1);
    }
}

int n = int.Parse(sr.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] input = sr.ReadLine().Split();
    switch(input[0])
    {
        case "push":
            Push(int.Parse(input[1]));
            break;
        case "pop":
            Pop();
            break;
        case "size":
            Size();
            break;
        case "empty":
            Empty();
            break;
        case "front":
            Front();
            break;
        case "back":
            Back();
            break;
    }
}
sw.Flush();