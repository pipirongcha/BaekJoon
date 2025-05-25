using System.Collections.Generic;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
Dictionary <(int, int, int), int> dict = new Dictionary< (int, int, int), int>();

for (int i = 1; i <= 20; i++)
{
    for (int j = 1; j <= 20; j++)
    {
        for (int k = 1; k <= 20; k++)
        {
            if (i < j && j < k)
            {
                if (k - 1 == 0)
                {
                    dict[(i, j, k - 1)] = 1;
                    dict[(i, j - 1, k - 1)] = 1;
                }
                if (j - 1 == 0)
                {
                    dict[(i, j - 1, k)] = 1;
                    if (!dict.ContainsKey((i, j - 1, k - 1)))
                    {
                        dict[(i, j - 1, k - 1)] = 1;
                    }
                }
                dict[(i, j, k)] = dict[(i, j, k - 1)] + dict[(i, j - 1, k - 1)] - dict[(i, j - 1, k)];
            }
            else
            {
                if (i - 1 == 0)
                {
                    dict[(i, j, k)] = 2;
                }
                else
                {
                    if (j - 1 == 0)
                    {
                        dict[(i - 1, j - 1, k)] = 1;
                        dict[(i - 1, j - 1, k - 1)] = 1;
                    }
                    if (k - 1 == 0)
                    {
                        dict[(i - 1, j, k - 1)] = 1;
                        if (!dict.ContainsKey((i - 1, j - 1, k - 1)))
                        {
                            dict[(i - 1, j - 1, k - 1)] = 1;
                        }
                    }
                    dict[(i, j, k)] = dict[(i - 1, j, k)] + dict[(i - 1, j - 1, k)] + dict[(i - 1, j, k - 1)] - dict[(i - 1, j - 1, k - 1)];
                }
            }
        }
    }
}

while (true)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int a = input[0];
    int b = input[1];
    int c = input[2];

    if (a == -1 && b == -1 && c == -1)
    {
        break;
    }
    if (a <= 0 || b <= 0 || c <= 0)
    {
        sw.WriteLine($"w({a}, {b}, {c}) = 1");
    }
    else if(a > 20 || b > 20 || c > 20)
    {
        sw.WriteLine($"w({a}, {b}, {c}) = {dict[(20, 20, 20)]}");
    }
    else
    {
        sw.WriteLine($"w({a}, {b}, {c}) = {dict[(a, b, c)]}");
    }
}
sw.Flush();

