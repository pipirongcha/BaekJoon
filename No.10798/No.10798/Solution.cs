using System.Text;

char[,] matrix = new char[5,15];
StringBuilder res = new StringBuilder();

for(int i = 0; i < 5; i++)
{
    string input = Console.ReadLine();
    for(int j = 0; j < input.Length; j++)
    {
        matrix[i,j] = input[j];
    }
}

for (int i = 0; i < 15; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if(matrix[j,i] != '\0')
        {
            res.Append(matrix[j, i]);
        }
    }
}

Console.WriteLine(res.ToString());    