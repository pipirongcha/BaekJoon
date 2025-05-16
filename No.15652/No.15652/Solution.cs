namespace No._15652
{
    using System.Text;
    internal class Solution
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];

            int[] arr = new int[m];
            StringBuilder sb = new StringBuilder();

            BackTracking(0, 0);
            Console.WriteLine(sb.ToString());

            void BackTracking(int depth, int prev)
            {
                if (m == depth)
                {
                    for (int i = 0; i < m; i++)
                    {
                        sb.Append(arr[i] + " ");
                    }
                    sb.Append("\n");

                    return;
                }

                for (int i = prev; i < n; i++)
                {
                    arr[depth] = i + 1;
                    BackTracking(depth + 1, i);
                }
            }
        }
    }
}
