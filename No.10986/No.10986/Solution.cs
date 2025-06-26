int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nm[0];
int m = nm[1];
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long [] modCount = new long[m];
long sum = 0;
long res = 0;

modCount[0] = 1;


for(int i = 0; i < n; i++)
{
    sum += arr[i];
    int mod = (int)(sum % m);
    modCount[mod]++;
}

for(int i = 0; i < m; i++)
{
    res += modCount[i] * (modCount[i] - 1) / 2;
}

Console.WriteLine(res);