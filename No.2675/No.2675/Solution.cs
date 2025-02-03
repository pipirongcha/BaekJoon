using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int m = int.Parse(input[0]);
    string s = input[1];

    for (int j = 0; j < s.Length; j++)
    {
        for (int k = 0; k < m; k++)
        {
            sb.Append(s[j]);
        }
    }
    sb.Append("\n");
}
Console.WriteLine(sb.ToString());

//더 나은 방안

/*
using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int m = int.Parse(input[0]);
    string s = input[1];

    foreach (char c in s)
    {
        sb.Append(c, m); // c 문자를 m번 반복해서 추가
    }
    sb.AppendLine(); // 줄바꿈
}
Console.WriteLine(sb.ToString());

 */