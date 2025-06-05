using System.Text;
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();

while(true)
{
    int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int n = arr[0];
    if (n == 0)
    {
        break;
    }
    int[] lotto = new int[6];
    BackTracking(arr, lotto, 0, 1);
    sb.AppendLine();
}

Console.WriteLine(sb.ToString());

void BackTracking(int[] arr, int[] lotto, int depth, int idx)
{
    if(depth == 6)
    {
        for (int i = 0; i < 6; i++)
        {
            sb.Append($"{lotto[i]} ");
        }
        sb.AppendLine();
        return;
    }
    for (int i = idx; i <= arr[0]; i++)
    {
       lotto[depth] = arr[i];
       BackTracking(arr, lotto, depth+1, i+1);
    }
}