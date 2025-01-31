int n = int.Parse(Console.ReadLine());
string[] tmp = Console.ReadLine().Split();
float[] list = new float[n];
float max = 0;
float res = 0;

for (int i = 0; i < tmp.Length; i++)
{
    list[i] = int.Parse(tmp[i]);
    if (list[i] > max)
    {
        max = list[i];
    }

}

for (int i = 0; i < n; i++)
{
    list[i] = list[i] / max * 100;
    res += list[i];
}

Console.WriteLine(res/n);