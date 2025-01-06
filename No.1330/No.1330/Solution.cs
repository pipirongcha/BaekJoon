string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

if (a > b) Console.WriteLine(">");
if (a < b) Console.WriteLine("<");
if (a == b) Console.WriteLine("==");