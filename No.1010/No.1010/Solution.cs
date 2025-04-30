StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine());

while(t > 0)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int n = input[1];
    int k = Math.Max(input[0], n - input[0]);
    int l = Math.Min(input[0], n - input[0]) ;
    double a = 1;
    double b = 1;

    for(int i = n; i >= 1; i--)
    {
        if(i > k)
        {
            a *= i;
        }
        if(i <= l)
        {
            b *= i;
        }

    }

    sw.WriteLine(a/b);
    t--;
}

sw.Flush();