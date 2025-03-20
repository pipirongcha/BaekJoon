int n = int.Parse(Console.ReadLine());
int m = 0;
long res = 666;
bool endNum = false;

while (m != n)
{
    string tmp = res.ToString();
    for (int i = 0; i <tmp.Length-2; i++)
    {
        if (tmp[i] == '6' && tmp[i+1] == '6' && tmp[i+2] == '6')
        {
            endNum = true;
        }
    }
    if (endNum)
    {
        m++;
    }
    if(m==n)
    {
        break;
    }
    res++;
    endNum = false;

}

Console.WriteLine(res);