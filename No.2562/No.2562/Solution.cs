int[] arr = new int[9];
int max = 0;
int idx = 0;

for (int i = 0; i < 9; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] >= max)
    {
        max = arr[i];
        idx = i + 1;
    }
}

Console.WriteLine($"{max}");
Console.WriteLine($"{idx}");