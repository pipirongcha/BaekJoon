StreamReader sr = new StreamReader(Console.OpenStandardInput());
HashSet<string> set = new HashSet<string>();
int n = int.Parse(sr.ReadLine());
int res = 0;
for (int i = 0; i < n; i++)
{
    string[] input = sr.ReadLine().Split();
    if (set.Contains(input[0]) || set.Contains(input[1]))
    {

        if (!set.Contains(input[0]))
        {
            res++;
            set.Add(input[0]);

        }
        else if(!set.Contains(input[1]))
        {
            res++;
            set.Add(input[1]);
        }

    }
    else if (input[0] == "ChongChong" || input[1] == "ChongChong")
    {
        res+=2;
        set.Add(input[0]);
        set.Add(input[1]);
    }
}
Console.Write(res);