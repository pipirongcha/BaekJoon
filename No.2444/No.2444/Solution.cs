int n = int.Parse(Console.ReadLine());
string[] a = new string[n * 2 - 1];

for (int i = 1; i <= n; i++)
{
    for (int j = 0; j <= n - i; j++)
    {
        a[j] = " ";
    }
    int k = 0;
    while (k < 2*i -1)
    {
        a[k + n - i] = "*";
        k++;
    }
    Console.WriteLine(string.Join("",a));
}



for (int i = n-1; i >= 1; i--)
{
    a = new string[n * 2 - 1];
    for (int j = 0; j <= n - i; j++)
    {
        a[j] = " ";
    }
    int k = 0;
    while (k < 2 * i - 1)
    {
        a[k + n - i] = "*";
        k++;
    }
    Console.WriteLine(string.Join("", a));
}




//출력형식 오류난 코드

//int n = int.Parse(Console.ReadLine());
//string[] a = new string[n * 2 - 1];

//int centerIdx = n - 1;
//int frontIdx = 0;
//int terminalIdx = a.Length - 1;

//for (int i = 0; i < a.Length; i++)
//{
//    a[i] = " ";
//}

//while (frontIdx != centerIdx && terminalIdx != centerIdx)
//{
//    a[centerIdx + frontIdx] = "*";
//    a[terminalIdx - centerIdx] = "*";
//    frontIdx++;
//    terminalIdx--;
//    Console.WriteLine(string.Join("", a));
//    if (frontIdx == centerIdx && terminalIdx == centerIdx)
//    {
//        a[0] = "*";
//        a[a.Length - 1] = "*";
//        Console.WriteLine(string.Join("", a));
//        break;
//    }
//}

//frontIdx = 0;
//terminalIdx = a.Length - 1;

//while (frontIdx != centerIdx && terminalIdx != centerIdx)
//{
//    a[frontIdx] = " ";
//    a[terminalIdx] = " ";
//    frontIdx++;
//    terminalIdx--;
//    Console.WriteLine(string.Join("", a));
//}

