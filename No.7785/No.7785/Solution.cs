using System.Collections.Immutable;
using System.Security.Cryptography;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

Dictionary<string, string> dict =  new Dictionary<string, string>();
int n = int.Parse(sr.ReadLine());
int j = 0;
int l = 0;

for(int i = 0; i < n; i++)
{
    string[] input = sr.ReadLine().Split();
    dict[input[0]] = input[1];
}

foreach (string key in dict.Keys)
{
    if (dict[key] == "enter")
    {
        l++;
    }
}

string[] list = new string[l];

foreach (string key in dict.Keys)
{
    if (dict[key] == "enter")
    {
        list[j] = key;
        j++;
    }
}

Array.Sort(list, (a, b) => b.CompareTo(a));

for (int i = 0; i < list.Length; i++)
{
    sw.WriteLine(list[i]);
}

sw.Flush();

