StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Dictionary<string, int> dict = new Dictionary<string, int>();

for (int i = 1; i <= nm[0]; i++)
{
    string target = sr.ReadLine();
    dict[target] = i;
}

string[] list = dict.Keys.ToArray();

for (int i = 0; i < nm[1]; i++)
{
    string target = sr.ReadLine();
    if (target[0] > 57)
    {
        sw.WriteLine(dict[target]);
    }
    else
    {
        int targetIdx = int.Parse(target);
        sw.WriteLine(list[targetIdx-1]);
    }
}

sw.Flush();