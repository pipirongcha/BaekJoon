int n = int.Parse(Console.ReadLine());
string[] inputs = Console.ReadLine().Split();
int[] arr = new int[n];
int v =  int.Parse(Console.ReadLine());

int result = 0; 

for(int i  = 0; i < n; i++)
{
    arr[i] = int.Parse(inputs[i]);
    if (arr[i] == v)
    {
        result++;
    }
}
Console.WriteLine(result);

