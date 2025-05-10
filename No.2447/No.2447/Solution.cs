using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder s =  new StringBuilder();
char[,] list = new char[n,n];

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        list[i, j] = ' '; 
    }
}

StarMaking(n, 0, 0);

void StarMaking(int n, int a, int b)
{
    if (n == 1)
    {
        list[a, b] = '*';
        return;
    }

    int m = n / 3;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (i == 1 && j == 1)
            {
                continue;
            }

            StarMaking(m, a + m * i, b + m * j);
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        s.Append(list[i,j]);
    }
    s.Append('\n');
}

Console.WriteLine(s.ToString());