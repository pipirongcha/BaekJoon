StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

while (true)
{
    string a = sr.ReadLine();
    if (a == null)
    {
        break;
    }
    int x = int.Parse(a) * 10000000;
    int n = int.Parse(sr.ReadLine());
    int[] lego = new int[n];
    int l1 = 0;
    int l2 = 0;
    int tmpL1 = 0;
    int tmpL2 = 0;
    Dictionary<int, bool> dict = new Dictionary<int, bool>();
    dict.Clear();
    for (int i = 0; i < n; i++)
    {
        lego[i] = int.Parse(sr.ReadLine());
        if (dict.ContainsKey(lego[i]))
        {
            dict[lego[i]] = true;
        }
        else
        {
            dict[lego[i]] = false;
        }
    }

    for (int i = 0; i < n; i++)
    {
        if (dict.ContainsKey(x - lego[i]))
        {

            if (x - lego[i] == lego[i] && !dict[x - lego[i]])
            {
                continue;
            }
            else
            {
                tmpL1 = Math.Min(lego[i], x - lego[i]);
                tmpL2 = Math.Max(lego[i], x - lego[i]);
                if (Math.Abs(tmpL1 - tmpL2) >= Math.Abs(l1 - l2))
                {
                    l1 = tmpL1;
                    l2 = tmpL2;
                }
            }
        }
    }


    if (l1 + l2 != x)
    {
        sw.WriteLine("danger");
    }
    else
    {
        sw.WriteLine($"yes {l1} {l2}");
    }
}

sw.Flush();