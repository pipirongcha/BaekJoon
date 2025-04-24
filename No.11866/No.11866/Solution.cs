StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nk[0];
int k = nk[1];
sw.Write("<");
Queue<int> queue = new Queue<int>();

for (int i = 1; i <= n; i++)
{
    queue.Enqueue(i);
}

while (queue.Count != 1)
{
    for (int i = 1; i < k; i++)
    {
        queue.Enqueue(queue.Dequeue());
    }
    sw.Write($"{queue.Dequeue()}, ");
}
sw.Write($"{queue.Dequeue()}>");

sw.Flush();
