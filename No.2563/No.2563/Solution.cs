int n = int.Parse(Console.ReadLine());
bool[,] space = new bool[100,100];
int res = 0;
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
   for (int j = a; j < a+10; j++)
    {
        for (int k = b; k < b+10; k++)
        {
            if (!space[j, k])
            {
                space[j, k] = true;
                res++;
                
            }
        }
    }
}

Console.WriteLine(res);