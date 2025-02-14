using System.Text;

string[] input = Console.ReadLine().Split(" ");
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int[,] a = new int[n,m];
int[,] b = new int[n,m];
int[,] res = new int[n,m];

for (int i = 0; i < n; i++)
{
    string[] aInput = Console.ReadLine().Split(" ");
    for (int j = 0; j < m; j++)
    {
        a[i,j] = int.Parse(aInput[j]);
    }
    
}

for (int i = 0; i < n; i++)
{
    string[] bInput = Console.ReadLine().Split(" ");
    for (int j = 0; j < m; j++)
    {
        b[i, j] = int.Parse(bInput[j]);
    }

}

for (int i = 0; i < n; i++)
{
    StringBuilder sb = new StringBuilder();
    for (int j = 0; j < m; j++)
    {
        res[i, j] = a[i, j] + b[i, j];
        sb.Append(res[i, j]+ " ");
    }
    Console.WriteLine(sb.ToString().TrimEnd());
}