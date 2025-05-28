StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n  = int.Parse(sr.ReadLine());
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

int res = input[0];
int current = input[0];


for (int i = 1; i < n; i++)
{
    current = Math.Max(input[i], current + input[i]);
    res = Math.Max(res, current); 
}

Console.WriteLine(res);