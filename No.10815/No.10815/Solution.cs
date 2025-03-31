StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] numsN = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int m = int.Parse(sr.ReadLine());
int[] numsM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

Dictionary<int, int> dict = new Dictionary<int, int>();

for(int i = 0; i < m; i++)
{
    dict[numsM[i]] = 0;
}

for(int i = 0; i < n; i++)
{
    dict[numsN[i]] = 1;
}

foreach(int i in numsM)
{
    sw.Write(dict[i] + " ");
}

sw.Flush();