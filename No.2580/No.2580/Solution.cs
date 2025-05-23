using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int[,] board = new int[9, 9];

for (int i = 0; i < 9; i++)
{
    int[] target = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int zero = 0;
    int idx = 0;
    int total = 0;
    for(int j = 0; j < 9; j++)
    {
        board[i, j] = target[j];
        if (target[j] == 0)
        {
            zero++;
            idx = j;
        }
        total += target[j];
    }
    if(zero == 1)
    {
        board[i,idx] = 45 - total;
    }
}

Sudoku();
Print();
sw.Write(sb.ToString());
sw.Flush();

bool Sudoku()
{
    int row, col;
    if (!FindEmpty(out row, out col))
    {
        return true;
    }

    for (int i = 1; i <= 9; i++)
    {
        if (IsValid(row, col, i))
        {
            board[row, col] = i;
            if (Sudoku())
            {
                return true;
            }
            board[row, col] = 0;
        }
    }
    return false;
}

bool FindEmpty(out int row, out int col)
{
    for (row = 0; row < 9; row++)
    {
        for (col = 0; col < 9; col++)
        {
            if (board[row, col] == 0)
                return true;
        }
    }
    row = col = -1;
    return false;
}

 bool IsValid(int row, int col, int num)
{
    for (int i = 0; i < 9; i++)
    {
        if (board[row, i] == num || board[i, col] == num)
            return false;
    }

    int rowStart = row / 3 * 3;
    int colStart = col / 3 * 3;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (board[rowStart + i, colStart + j] == num)
                return false;
        }
    }

    return true;
}

 void Print()
{
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            sb.Append(board[i, j] + " ");
        }
        sb.AppendLine();
    }
}
