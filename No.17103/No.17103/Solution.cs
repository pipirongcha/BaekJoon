StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

Dictionary<int,bool> primeNums = new Dictionary<int, bool>();
primeNums[2] = false;
for (int i = 3; i <= 1000000; i++)
{
    int j = 2;
    while (true)
    {
        int tmp = i % j;
        if (tmp == 0 && j <= Math.Sqrt(i))
        {
            break;
        }
        else if(j>Math.Sqrt(i))
        {
            primeNums[i] = false;
            break;
        }
        else
        {
            j++;
        }
    }
}

int n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    int res = 0;
    int target = int.Parse(sr.ReadLine());
    for (int j = 2; j <= target/2; j++)
    {
        if(primeNums.ContainsKey(j)&&primeNums.ContainsKey(target-j))
        {
            res++;
        }
    }
    sw.WriteLine(res);
}
sw.Flush();