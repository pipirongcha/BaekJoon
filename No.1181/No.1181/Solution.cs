StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
string[] input = new string[n];
for (int i = 0; i < n; i++)
{
    input[i] = sr.ReadLine();
}

input = input.Distinct().ToArray();

Array.Sort(input,(a,b) =>
{
    if(a.Length != b.Length) 
        return a.Length.CompareTo(b.Length);
    else
    {
        for(int i = 0;i < a.Length;i++)
        {
            if(a[i] < b[i]) 
                return -1;
            else if (a[i] == b[i])
            {
                continue;
            }
            else
            {
                return 1;
            }
        }
        return 1;
    }
});

for (int i = 0; i <input.Length; i++)
{
    sw.WriteLine(input[i]);
}

sw.Flush();