StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine());

for (int i = 0; i < t; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int a = Math.Max(input[0], input[1]);
    int b = Math.Min(input[0], input[1]);
    int r = 0;

    while (b != 0)
    {
        r = a % b;
        a = b;
        b = r;
    }
    sw.WriteLine(input[0]*input[1]/ a);
}

sw.Flush();