int num1 = int.Parse(Console.ReadLine());
string tmpNum2 = Console.ReadLine();

int[] num2 = new int[tmpNum2.Length];
for (int i = 0; i < num2.Length; i++)
{
    num2[i] = int.Parse(tmpNum2[i].ToString());
}

int num3 = num2[2] * num1;
int num4 = (num2[1] * 10) * num1;
int num5 = (num2[0] * 100) * num1;

Console.WriteLine(num3);
Console.WriteLine(num4/10);
Console.WriteLine(num5/100);
Console.WriteLine(num3+num4+num5);
