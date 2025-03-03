string[] input = Console.ReadLine().Split();
float x = float.Parse(input[0]);
float y = float.Parse(input[1]);

float n = float.Parse(input[2])-x;
float m = float.Parse(input[3])-y;

float a = MathF.Min(x, y);
float b = MathF.Min(n, m);
Console.WriteLine(MathF.Min(a, b));