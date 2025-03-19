string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
char[,] board = new char[n, m];
int res = 32;
int tmp = 32;

for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        board[i, j] = line[j];
    }
}

for (int i = 0;i+7 < n; i++)
{
    for (int j = 0; j+7 < m; j++)
    {
        int tmpW = 0; 
        int tmpB = 0;
        bool w = true; 

        int k = 0, l = 0;
        while (k < 8)
        {
            l = 0;
            while (l < 8)
            {
                char current = board[i + k, j + l];

                if ((w && current != 'W') || (!w && current != 'B'))
                {
                    tmpW++;
                }

                if ((w && current != 'B') || (!w && current != 'W'))
                {
                    tmpB++;
                }

                w = !w;
                l++;
            }
            k++;
            w = !w;
        }

        int min = Math.Min(tmpW, tmpB);
        if (min < res)
        {
            res = min;
        }
    }
}

Console.WriteLine(res);
