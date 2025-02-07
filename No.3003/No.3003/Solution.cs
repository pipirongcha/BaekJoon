int[] res = { 1, 1, 2, 2, 2, 8 };
string[] inputs = Console.ReadLine().Split();

for (int i = 0; i < inputs.Length; i++)
{
    res[i] -= int.Parse(inputs[i]);
}
Console.WriteLine(string.Join(" ",res));