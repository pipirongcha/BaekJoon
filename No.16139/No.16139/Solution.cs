StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string s = sr.ReadLine();
int q = int.Parse(sr.ReadLine());
int n = s.Length;
int[,] prefixSum = new int[n,26];

prefixSum[0,s[0]-97] = 1;

for (int i = 1; i < n; i++)
{
    for (int j = 0; j < 26; j++)
    {
        if (j == s[i] - 97)
        {
            prefixSum[i, j] = prefixSum[i - 1, j] + 1;
        }
        else
        {
            prefixSum[i, j] = prefixSum[i - 1, j];
        }
    }
}

for (int i = 0; i < q; i++)
{
    string[] input = sr.ReadLine().Split();
    char a = input[0][0];
    int l = int.Parse(input[1]);
    int r = int.Parse(input[2]);

    if (l != 0)
    {
        sw.WriteLine(prefixSum[r, a - 97] - prefixSum[l - 1, a - 97]);
    }
    else
    {
        sw.WriteLine(prefixSum[r, a - 97]);
    }

}

sw.Flush();