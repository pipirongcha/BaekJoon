string input = Console.ReadLine();
input = input.ToUpper();
int[] arr = new int[26];

for (int i = 0; i < input.Length; i++)
{
    arr[input[i] - 65] ++;
}

int max = arr.Max();
int count = 0;

for (int i = 0;i < arr.Length;i++)
{
    if (arr[i] == max)
    {
        count++;
    }
    if (count > 1)
    {
        break;
    }

}

if (count >1)
{
    Console.WriteLine("?");
}
else
{
    int idx = Array.IndexOf(arr, max)+65;
    Console.WriteLine((char)idx);
}