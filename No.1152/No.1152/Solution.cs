string[] input = Console.ReadLine().Split();
int res = input.Length;

if (input[0] == "")
{
    res--;
}

if (input[input.Length - 1] == "")
{
    res--;
}


Console.WriteLine(res);


//메모리를 최적화한 코드

/*
string input = Console.ReadLine().Trim(); // 앞뒤 공백 제거
int count = 0;
bool inWord = false;

foreach (char c in input)
{
    if (c == ' ')
    {
        inWord = false; // 공백이면 단어가 끝남
    }
    else if (!inWord)
    {
        count++; // 단어 시작 지점 발견
        inWord = true;
    }
}

Console.WriteLine(count);
 */