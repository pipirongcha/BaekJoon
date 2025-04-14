StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int i = 2;
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int m = input[0];
int n = input[1];

if(m < 2)
{
    m = 2;
}

while(m <= n)
{
    int tmp = m % i;
    if(i>Math.Sqrt(m))
    {
        sw.WriteLine(m);
        m++;
        i=2;
    }
    else if(tmp == 0 && i <= Math.Sqrt(m))
    {
        m++;
        i = 2;
    }
    else
    {
        i++;
    }
}

sw.Flush();