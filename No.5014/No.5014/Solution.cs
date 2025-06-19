int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int f = input[0];
int s = input[1];
int g = input[2];
int u = input[3];
int d = input[4];

int res = 0;
int[] visited = new int[f+1]; //Button Push Count (idx == floor, val == count)
Queue<int> q = new Queue<int>(); //BFS

q.Enqueue(s);
visited[s] = 1;

while (q.Count > 0)
{
    int now = q.Dequeue();

    foreach (int i in new int[] {now + u, now - d})
    {
        if(i > 0 && i <= f && visited[i] == 0)
        {
            visited[i] = visited[now] + 1;
            q.Enqueue(i);
        }
    }
}
Console.Write(visited[g] > 0 ? visited[g] - 1 : "use the stairs");


