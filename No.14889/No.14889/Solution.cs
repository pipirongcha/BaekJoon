StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
int[,] s = new int[n,n];
bool[] visit = new bool[n];

int res = 1000; 
for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for(int j = 0; j < n; j++)
    {
        s[i,j] = input[j];
    }
}

TeamMatch(0,0);
Console.WriteLine(res);

void TeamMatch(int depth, int prev)
{
    if (depth == n/2)
    {
        int start = 0;
        int link = 0;

        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (visit[i] && visit[j])
                {
                    start += s[i, j];
                }
                else if (!visit[i] && !visit[j])
                {
                    link += s[i, j];
                }
            }
        }
        int calculate = Math.Max(start, link) - Math.Min(start, link);
        if (calculate < res)
        {
            res = calculate;
        }
        return;
    }

    for (int i = prev; i < n; i++)
    {
        visit[i] = true;
        TeamMatch(depth+1,i+1);
        visit[i] = false;
        
    }
}