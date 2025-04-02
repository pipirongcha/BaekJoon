StreamReader sr = new StreamReader(Console.OpenStandardInput());
Dictionary<string, int> dict = new Dictionary<string, int>();

int[] len = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
string[] arr = new string[len[1]];
int res = 0;

for (int i = 0; i < len[0]; i++)
{
    dict[sr.ReadLine()] = 0;
}

for (int i = 0; i < len[1]; i++)
{
    arr[i] = sr.ReadLine();
}

for (int i = 0; i < len[1]; i++)
{
    if (dict.ContainsKey(arr[i]))
    {
        dict[arr[i]]++;
    }
}

foreach (KeyValuePair<string, int> i in dict)
{
    res += i.Value;
}

Console.WriteLine(res);