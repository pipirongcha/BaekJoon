using System.Linq;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];

Dictionary<string, int> dict = new Dictionary<string, int>(); // key: input, val: num of times key was added

for (int i = 0; i < n; i++)
{
    string input = sr.ReadLine();
    int len = input.Length;
    if (m <= len)
    {
        if (dict.ContainsKey(input))
        {
            dict[input]++;
        }
        else
        {
            dict[input] = 1;
        }
    }
}

IEnumerable<string> words = dict.OrderByDescending(a => a.Value)
    .ThenByDescending(a => a.Key.Length)
    .ThenBy(a => a.Key)
    .Select(a => a.Key);

foreach (string word in words)
{
    sw.WriteLine(word);
}
sw.Flush();

/* 
 Other Solution(Sort) 
*/

//StreamReader sr = new StreamReader(Console.OpenStandardInput());
//StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

//int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
//int n = nm[0];
//int m = nm[1];

//Dictionary<string,int> dict = new Dictionary<string,int>(); // key: input, val: num of times key was added

//for(int i = 0; i < n; i++)
//{
//    string input = sr.ReadLine();
//    int len = input.Length;
//    if (m <= len)
//    {
//        if(dict.ContainsKey(input))
//        {
//            dict[input]++;
//        }
//        else
//        {
//            dict[input] = 1;
//        }
//    }
//}

//dict = dict.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);

//string[] res = new string[dict.Count];

//int c = 0;
//foreach (KeyValuePair<string, int> i in dict)
//{
//    res[c] = i.Key;
//    c++;
//}

//Array.Sort(res, (a, b) =>
//{
//    int x = dict[b].CompareTo(dict[a]);
//    if (x != 0)
//    {
//        return x;
//    }

//    x = b.Length.CompareTo(a.Length);
//    if (x != 0)
//    {
//        return x;
//    }

//    return string.CompareOrdinal(a, b);
//});


//for (int i = 0; i < res.Length; i++)
//{
//    sw.WriteLine(res[i]);
//}

//sw.Flush();