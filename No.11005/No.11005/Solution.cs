using System.Text;

Dictionary<int, char> dict = new Dictionary<int, char>();

for (int i = 0; i <26; i++)
{
    dict.Add(10+i,(char)(65 + i));
}

string[] input = Console.ReadLine().Split();
int num = int.Parse(input[0]);
int numeral = int.Parse(input[1]);
StringBuilder res = new StringBuilder();

while (num > 0)
{

    int calculate = num%numeral;
    if (calculate <= 9)
    {
        res.Insert(0, calculate);
    }
    else
    {
        res.Insert(0, dict[calculate]);
    }
    num = num/numeral;
}

Console.WriteLine(res.ToString());

