string[] tmpInput = Console.ReadLine().Split();
int n = int.Parse(tmpInput[0]);
int m = int.Parse(tmpInput[1]);
int[] result = new int[n];

for(int a = 1; a <= m; a++)
{
    string[] tmpInput2 = Console.ReadLine().Split();
    int i = int.Parse(tmpInput2[0])-1;
    int j = int.Parse(tmpInput2[1])-1;
    int k = int.Parse(tmpInput2[2]);
    while(i <= j)
    {
        result[i] = k;
        i++;
    }
}

Console.WriteLine(string.Join(" ",result));
