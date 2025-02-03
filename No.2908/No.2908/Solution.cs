using System.Text;

string[] inputs = Console.ReadLine().Split();

StringBuilder a = new StringBuilder();
StringBuilder b = new StringBuilder();

for (int i = 1; i <= inputs[0].Length; i++)
{
    a.Append(inputs[0][inputs[0].Length - i]);
}


for (int i = 1; i <= inputs[1].Length; i++)
{
    b.Append(inputs[1][inputs[1].Length - i]);
}

Console.WriteLine(Math.Max(int.Parse(a.ToString()), int.Parse(b.ToString())));


//코드 직관성 개선되고, 메모리 효율이 더 좋은 코드 

/*
using System;
using System.Linq;

string[] inputs = Console.ReadLine().Split();

int a = int.Parse(new string(inputs[0].Reverse().ToArray()));
int b = int.Parse(new string(inputs[1].Reverse().ToArray()));

Console.WriteLine(Math.Max(a, b));
 */