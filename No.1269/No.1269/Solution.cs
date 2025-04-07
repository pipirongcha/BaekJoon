int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] numsN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] numsM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = nm[0];
int m = nm[1];
int countN = n;
int countM = m;

Dictionary<int, bool> dict = new Dictionary<int, bool>();
int[] arr = new int[Math.Min(n,m)];

for(int i = 0; i < n; i++)
{
    dict[numsN[i]] = true;
}

for (int i = 0; i < m; i++)
{
    if (dict.ContainsKey(numsM[i]))
    {
        dict[numsM[i]] = false;
    }
    else 
    {
        dict[numsM[i]] = true;
    }
}

for (int i = 0;i < n; i++)
{
    if (!dict[numsN[i]])
    {
        countN--;
    }
}

for(int i = 0; i<m; i++)
{
    if (!dict[numsM[i]])
    {
        countM--;
    }
}

Console.WriteLine(countM+countN);