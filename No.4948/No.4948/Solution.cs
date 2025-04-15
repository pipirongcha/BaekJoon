StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int input = int.Parse(sr.ReadLine());
while(input != 0)
{
    int res = 0;
    int n = input + 1;
    int m = input * 2;
    int i = 2;
    while (n <= m)
    {
        int tmp = n%i;
        if (tmp == 0 && i <= Math.Sqrt(n))
        {
            i = 2;
            n++;
        }
        else if(i > Math.Sqrt(n))
        {
            res++;
            i = 2;
            n++;
        }
        else
        {
            i++;
        }
    }
    sw.WriteLine(res);
    input = int.Parse(sr.ReadLine());
}
sw.Flush();