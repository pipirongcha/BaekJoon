StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int t = int.Parse(sr.ReadLine());

for(int i = 0; i < t; i++)
{
    string target = sr.ReadLine();
    int check = 0;

    for(int j = 0; j < target.Length; j++)
    {
        if (check < 0)
        {
            break;
        }
        if(target[j] == '(')
        {
            check++;
        }
        else
        {
            check--;
        }
    }
    if(check == 0)
    {
        sw.WriteLine("YES");
    }
    else
    {
        sw.WriteLine("NO");
    }
}

sw.Flush();