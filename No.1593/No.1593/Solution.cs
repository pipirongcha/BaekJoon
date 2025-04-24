int[] gs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int g = gs[0];
int sLen = gs[1];
string w = Console.ReadLine();
string s = Console.ReadLine();

Dictionary<char, int> dict = new Dictionary<char, int>(); // Key: char in w, Val: how many Key in w 
Dictionary<char, int> dictR = new Dictionary<char, int>(); 

int res = 0;
int tmp = 0;

for (int i = 0; i < g; i++)
{
    if (dict.ContainsKey(w[i]))
    {
        dict[w[i]]++;
    }
    else
    {
        dict[w[i]] = 1;
        dictR[w[i]] = 0;
    }
}

for (int i = 0;i < g; i++)
{
    if (dictR.ContainsKey(s[i]))
    {
        tmp++; 
        dictR[s[i]]++;
    }
}

if (tmp == g)
{
    int j = 0;
    foreach(KeyValuePair<char, int> i in dictR)
    {
        if(dictR[i.Key] != dict[i.Key])
        {
            break;
        }
        j++;
    }
    if(j == dict.Count)
    {
        res++;
    }
}

for (int i = g; i<sLen; i++)
{
    if (dictR.ContainsKey(s[i-g]))
    {
        tmp--;
        dict[s[i-g]]++;
    }
    if (dict.ContainsKey(s[i]))
    {
        tmp++;
        dict[s[i]]--;
    }
    if (tmp == g)
    {
        int j = 0;

        foreach (KeyValuePair<char, int> k in dictR)
        {
            if (dictR[k.Key] != dict[k.Key])
            {
                break;
            }
            j++;
        }
        if (j == dict.Count)
        {
            res++;
        }
    }
}
Console.WriteLine(res);