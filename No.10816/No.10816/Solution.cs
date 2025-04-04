StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] numsN = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int m = int.Parse(sr.ReadLine());
int[] numsM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

Dictionary<int, int> dict = new Dictionary<int, int>();

for (int i = 0; i < m; i++)
{
    dict[numsM[i]] = 0;
}

for (int i = 0; i < n; i++)
{
    if (dict.ContainsKey(numsN[i]))
    {
        dict[numsN[i]]++;
    }
}

for (int i = 0; i < m; i++)
{

    sw.Write($"{dict[numsM[i]]} ");
}

sw.Flush();