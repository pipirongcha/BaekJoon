using System.Text;

int input = int.Parse(Console.ReadLine());
int tmp = 0;
StringBuilder sb = new StringBuilder();

while (input != -1)
{
    for (int i = input-1; i > 1; i--)
    { 
        int a = input - i;
        if (input % a == 0)
        {
            if (a != 0 && a != input)
            {
                sb.Append(a + " + ");
                tmp += a;
            }
        }
    }
    if (tmp == input)
    {
        sb.Remove(sb.Length - 3, 3);
        Console.WriteLine($"{input} = {sb.ToString()}");
    }
    else
    {
        Console.WriteLine($"{input} is NOT perfect.");
    }
    tmp = 0;
    input = int.Parse(Console.ReadLine());
    sb.Clear();
}