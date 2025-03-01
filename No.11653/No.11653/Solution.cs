int input = int.Parse(Console.ReadLine());
int tmp = 2;

while (input != 1)
{
    if (input % tmp == 0)
    {
        Console.WriteLine(tmp);
        input /= tmp;
    }
    else
    {
        tmp++;
    }
}

//더 큰 합성수는 이미 소수를 체크했기 때문에 굳이 소수인지 확인할 필요가 없다...