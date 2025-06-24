int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0];
int score = input[1];
int p = input[2];

if (n != 0)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    List<int> ranking = arr.ToList();
    ranking.Add(score);
    ranking.Sort((a,b) => b.CompareTo(a));

    int res = ranking.IndexOf(score) + 1;

    if(res > p || n + 1 > p && ranking[p] == score)
    {
        Console.WriteLine(-1);
    }
    else
    {
        Console.WriteLine(res);
    }

}
else
{
    Console.WriteLine(1);
}



