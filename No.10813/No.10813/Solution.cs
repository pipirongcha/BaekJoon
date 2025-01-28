string[] inputs = Console.ReadLine().Split();
int n = int.Parse(inputs[0]);
int m = int.Parse(inputs[1]);

int i;
int j;
string[] inputs2;
int[] res = new int[n];

for (int a = 0; a < n; a++)
{
    res[a] = a+1;
}

for (int a = 0; a < m; a++)
{
    inputs2 = Console.ReadLine().Split();
    i = int.Parse(inputs2[0])-1;
    j = int.Parse(inputs2[1])-1;
    int tmp = res[i];
    res[i] = res[j];
    res[j] = tmp;

}

Console.WriteLine(string.Join(" ",res));