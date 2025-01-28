bool[] res = new bool[30];
int n;
int min = 0;
int max = 0;

for (int i = 0; i < 28; i++)
{
    n = int.Parse(Console.ReadLine())-1;
    res[n] = true;
}
for (int i = 0; i < res.Length; i++)
{
    if (res[i] == false && min == 0)
    {
        min = i+1;
    }
    else if (res[i] == false && max == 0)
    {
        max = i+1;
    }
}

Console.WriteLine(min.ToString());
Console.WriteLine(max.ToString());