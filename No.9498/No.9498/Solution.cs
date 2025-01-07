string input = Console.ReadLine();
int score = int.Parse(input);
if (90 <= score && score <= 100) Console.WriteLine("A");
else if (80 <= score && score <= 89) Console.WriteLine("B");
else if (70 <= score && score <= 79) Console.WriteLine("C");
else if (60 <= score && score <= 69) Console.WriteLine("D");
else Console.WriteLine("F"); 