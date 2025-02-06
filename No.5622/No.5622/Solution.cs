using System.Diagnostics;

int[] nums = new int[10];

for (int i = 1; i < 10; i++)
{
    nums[i] = i + 1; 
}

Dictionary<char, int> chars = new Dictionary<char, int>();
int alphabet = 65;
int limit = 0;

for (int i = 2; i < 10; i++)
{
    if (i != 7 && i != 9) { limit = alphabet + 3; }
    else { limit = alphabet + 4; }
    while (alphabet < limit)
    {
        chars.Add((char)alphabet, i);
        alphabet++;
    }
    
}


char[] inputs = Console.ReadLine().ToCharArray();
int res = 0;

for (int i = 0; i < inputs.Length; i++)
{
    res += nums[chars[inputs[i]]];
}

Console.WriteLine(res);

//개선 코드
//using System;

//int[] dial = new int[26]; // A~Z에 대한 숫자 매핑

//string[] mapping = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

//for (int i = 0; i < mapping.Length; i++)
//{
//    foreach (char c in mapping[i])
//    {
//        dial[c - 'A'] = i + 2; // 2~9까지 매핑
//    }
//}

//char[] inputs = Console.ReadLine().ToCharArray();
//int res = 0;

//foreach (char c in inputs)
//{
//    res += dial[c - 'A'] + 1; // 버튼 누르는 시간 = 숫자 + 1
//}

//Console.WriteLine(res);
