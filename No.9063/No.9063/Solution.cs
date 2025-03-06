int n = int.Parse(Console.ReadLine());
int xMin = 10000;
int xMax = -10000;
int yMin = 10000;
int yMax = -10000;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);

    if(x < xMin)
    {
        xMin = x;
    }
    if (x > xMax)
    {
        xMax = x;
    }
    if (y < yMin)
    {
        yMin = y;
    }
    if (y > yMax)
    {
        yMax = y;
    }
}

Console.WriteLine((xMax-xMin)*(yMax-yMin));