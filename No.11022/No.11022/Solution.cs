int t = int.Parse(Console.ReadLine());

for (int i = 1; i <= t; i++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);


    Console.WriteLine($"Case #{i}: {a} + {b} = {a+b}");
}

/*
 * 문자열 보간: 문자열 내에 변수, 함수, 수식 등의 값을 그대로 집어넣고 싶을 때 사용하는 기능
 * 문자열 시작 전, 맨 앞에 $을 붙여서 문자열 보간을 사용하겠다는 신호를 준다.
 * 값을 그대로 집어넣고 싶은 변수, 함수, 수식 등을 중괄호 안에 써넣는다. 
 */