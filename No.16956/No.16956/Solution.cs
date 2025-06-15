StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int[] rc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int r = rc[0];
int c = rc[1];
char[,] farm = new char[r, c];
bool wolfCome = false;

sw.WriteLine(1);

for (int i = 0; i < r; i++)
{
    string input = sr.ReadLine();
    for (int j = 0; j < c; j++)
    {
        farm[i, j] = input[j];
        if (farm[i, j] == '.')
        {
            farm[i, j] = 'D';
        }
    }
}

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        sw.Write(farm[i, j]);
        if (farm[i, j] == 'S')
        {
            if (i + 1 < r && farm[i + 1, j] == 'W')
            {
                wolfCome = true;
                break;
            }
            if (i - 1 >= 0 && farm[i - 1, j] == 'W')
            {
                wolfCome = true;
                break;
            }
            if (j + 1 < c && farm[i, j + 1] == 'W')
            {
                wolfCome = true;
                break;
            }
            if (j - 1 >= 0 && farm[i, j - 1] == 'W')
            {
                wolfCome = true;
                break;
            }
        }
    }
    sw.WriteLine();
}

if (wolfCome)
{
    Console.Write(0);
}
else
{

    sw.Flush();
}
