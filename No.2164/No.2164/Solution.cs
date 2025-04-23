int n = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
for (int i = 0; i < n; i++)
{
    queue.Enqueue(i + 1);
}

while (queue.Count != 1)
{
    queue.Dequeue();
    queue.Enqueue(queue.Dequeue());
}

Console.WriteLine(queue.Dequeue());