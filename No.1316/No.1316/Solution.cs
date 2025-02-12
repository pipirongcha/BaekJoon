int n = int.Parse(Console.ReadLine());
string target;
int res = 0;
List<char> usedChar = new List<char>(); 

for (int i = 0; i < n; i++)
{
    target = Console.ReadLine();
    if (target.Length == target.Distinct().Count())
    {
        res++;
    }
    else
    {
        for (int j = 0; j < target.Length; j++)
        {
            char tmp = target[j];
            if (j+1 < target.Length && tmp == target[j+1])
            {
                continue;
            }
            else
            {
                usedChar.Add(tmp);
            }
        }
        if (usedChar.Count == usedChar.Distinct().ToList().Count)
        {
            res++;
            usedChar.Clear();
        }
        else
        {
            usedChar.Clear();
        }
    }

}

Console.WriteLine(res);