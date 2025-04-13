StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

double n = double.Parse(sr.ReadLine());

for (double i = 0; i < n; i++)
{
    double target = double.Parse(sr.ReadLine());
    double j = 2;
    if (target < 2)
    {
        sw.WriteLine(2);
    }
    else
    {
        while (true)
        {
            double tmp = target % j;
            if (tmp == 0 && j <= Math.Sqrt(target))
            {
                target++;
                j = 2;
            }
            else if (j >= Math.Sqrt(target))
            {
                break;
            }
            else
            {
                j++;
            }
        }
        sw.WriteLine(target);
    }
}

sw.Flush();