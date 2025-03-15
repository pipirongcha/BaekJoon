string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

string[] cards = Console.ReadLine().Split();
int max = 0;

for (int i = 0; i < n - 2; i++)
{
    int a = int.Parse(cards[i]);
    for (int j = i + 1; j < n - 1; j++)
    {
        int b = int.Parse(cards[j]);
        for (int k = j + 1; k < n; k++)
        {
            int c = int.Parse(cards[k]);
            int calculate = a + b + c;
            if (calculate <= m && calculate > max)
            {
                max = calculate;
            }
        }
    }
}

Console.WriteLine(max);