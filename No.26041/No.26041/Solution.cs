string[] input = Console.ReadLine().Split();
int count = 0;
bool check = false;
string head = Console.ReadLine();

for(int i = 0; i < input.Length; i++)
{

    if (head.Length < input[i].Length)
    {
        check = true;
        for (int j = 0; j < head.Length; j++)
        {
            if (input[i][j] != head[j])
            {
                check = false;
                break;
            }
        }
        if (check)
        {
            count++;
            check = false;
        }
    }
}

Console.Write(count);