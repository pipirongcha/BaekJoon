string[] input1 = Console.ReadLine().Split();
int input2 = int.Parse(Console.ReadLine());

int h = int.Parse(input1[0]);
int m = int.Parse(input1[1]);

m = m + input2;

h += m / 60;
m = m % 60;

if (h >= 24)
{
    h -= 24;
}
string hour = h.ToString();
string min = m.ToString();
Console.WriteLine(hour + " "+min);

