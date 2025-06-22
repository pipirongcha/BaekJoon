StreamReader sr = new StreamReader(Console.OpenStandardInput());
int[] ndkc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
HashSet<int> set = new HashSet<int>();
int n = ndkc[0];
int d = ndkc[1];
int k = ndkc[2];
int c = ndkc[3];
bool couponSushi = false;
LinkedList<int> sushiNum = new LinkedList<int>();

int max = 0;

for(int i = 0; i < n; i++)
{
    int input = int.Parse(sr.ReadLine());
    sushiNum.AddLast(input);
}

LinkedListNode<int> startSushi  = sushiNum.First;

for (int i = 0; i < n; i++)
{
    LinkedListNode<int> currentSushi = startSushi;

    for (int j = 0; j < k; j++)
    {
        if (currentSushi == null)
        {
            currentSushi = sushiNum.First;
        }
        set.Add(currentSushi.Value);
        currentSushi = currentSushi.Next;
    }
    if (!set.Contains(c))
    {
        set.Add(c);
    }
    max = Math.Max(max, set.Count);
    set.Clear();
    startSushi = startSushi.Next;
}
Console.Write(max);