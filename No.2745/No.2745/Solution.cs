Dictionary<char, int> dict = new Dictionary<char, int>();

for (int i = 0; i < 26; i++)
{
    dict.Add((char)(65 + i), 10 + i);
}

string[] input = Console.ReadLine().Split();
int res = 0;
int m = input[0].Length-1;
int n = 0;

for (int i = 0; i <= m; i++)
{
    if (65 <= input[0][i])
    {
        n = dict[input[0][i]];
    }
    else
    {
        n = int.Parse(input[0][i].ToString());
    }
    res += n * (int)Math.Pow(int.Parse(input[1]), m - i);
}

Console.WriteLine(res);


/* 개선된 코드
Dictionary<char, int> dict = new Dictionary<char, int>();
for (int i = 0; i < 26; i++)
{
    dict.Add((char)(65 + i), 10 + i);
}

string[] input = Console.ReadLine().Split();
int res = 0;
int m = input[0].Length - 1;
int baseNum = int.Parse(input[1]); //연산 중복 방지위해 미리 연산값 저장

for (int i = 0; i <= m; i++)
{
    char c = input[0][i];
    int n;

    if (char.IsDigit(c))  // 숫자인 경우
    {
        n = c - '0';  // 문자 '0'~'9'를 정수로 변환
    }
    else  // 알파벳인 경우 (A~Z)
    {
        n = dict[c];
    }

    res += n * (int)Math.Pow(baseNum, m - i);
}

Console.WriteLine(res);

*/