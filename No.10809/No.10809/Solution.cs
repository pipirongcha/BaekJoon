Dictionary<char, int> dict = new Dictionary<char, int>();
int tmp = 97;

for (int i = 0; i < 26;  i++)
{
    char chr = (char)tmp;
    dict.Add(chr, -1);
    tmp++;
}

string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (dict[input[i]] == -1)
    {
        dict[input[i]]= i;
    }
}

Console.WriteLine(string.Join(" ",dict.Values));



//더 효율좋은 풀이...

/*
int[] position = Enumerable.Repeat(-1, 26).ToArray(); // -1로 초기화
string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    int idx = input[i] - 'a'; // a~z를 0~25 인덱스로 변환
    if (position[idx] == -1)
    {
        position[idx] = i;
    }
}

Console.WriteLine(string.Join(" ", position));
*/