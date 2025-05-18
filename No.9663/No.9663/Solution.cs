namespace No._9663
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] board = new int[n,n];
            int res = 0;

            Nqueen(1);
            Console.Write(res);
            void Nqueen(int nums) //nums: nums of queens on the board
            {
                if(nums > n)
                {
                    res++;
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    if (board[nums-1, i] == 0)
                    {
                        BoolChange(nums-1, i, true);
                        Nqueen(nums + 1);
                        BoolChange(nums-1, i, false);
                    }
                }
            }

            void BoolChange(int i, int j, bool check)
            {
                int tmp = 0;
                int a = i;
                int b = j;
                int c = j;
                while (b > 0 && a != 0)
                {
                    a--;
                    b--;
                }
                while (b <= n - 1 && a <= n-1)
                {
                    if (check)
                    {
                        board[a, b]++;
                    }
                    else
                    {
                        board[a, b]--;
                    }
                    b++;
                    a++;
                }
                a = i;
                while (c < n-1 && a != 0)
                {
                    a--;
                    c++;
                }
                while (c >= 0 && a <= n-1)
                {
                    if (check)
                    {
                        board[a, c]++;
                    }
                    else
                    {
                        board[a, c]--;
                    }
                    c--;
                    a++;
                }
                while (tmp < n)
                {
                    if (check)
                    {
                        board[tmp, j]++;
                        board[i, tmp]++;
                    }
                    else
                    {
                        board[tmp, j]--;
                        board[i, tmp]--;
                    }

                    tmp++;
                }

            }
        }
    }
}
