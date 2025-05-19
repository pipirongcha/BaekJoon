StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine());

for(int i = 0; i < t; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int a = input[0]%10;
    int b = input[1];
    List<char> c = new List<char>();
    int d = 1;
    int e = a;
    c.Add(a.ToString()[0]);
    while (true)
    {
        e *= a;
        string s = e.ToString();
        if (s[s.Length - 1] != c[0])
        {
            c.Add(s[s.Length - 1]);
            d++;
        }
        else
        {
            c.Insert(0, c[c.Count-1]);
            break;
        }
    }


    if(c[b % (c.Count - 1)] != '0')
    {
        sw.WriteLine(c[b % (c.Count - 1)]);
    }
    else
    {
        sw.WriteLine(10);
    }
}
sw.Flush();