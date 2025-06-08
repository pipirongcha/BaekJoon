int[] ns = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = ns[0];
int s = ns[1];
int count = 0;
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


BackTracking(0, 0);

void BackTracking(int depth, int sum)
{
    if (depth == n)
    {
        if (sum == s)
        {
            count++;
        }
        return;
    }

    BackTracking(depth + 1, sum + arr[depth]);
    BackTracking(depth + 1, sum);

}

if (s == 0)
{
    Console.WriteLine(count - 1);
}
else
{
    Console.WriteLine(count);
}