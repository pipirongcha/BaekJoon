StreamReader sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
Dictionary<string,bool> dict = new Dictionary<string,bool>();
int res = 0;

for(int i = 0; i < n; i++)
{
    string input = sr.ReadLine();
    if (input == "ENTER")
    {
        dict.Clear();
    }
    else
    {
        if (!dict.ContainsKey(input))
        {
            res++;
            dict.Add(input, true);
        }
    }
 
}

Console.WriteLine(res);