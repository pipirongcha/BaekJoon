using System.Text;

int t = int.Parse(Console.ReadLine());

StringBuilder result = new StringBuilder();

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    result.Append(a+b + "\n");
}

Console.WriteLine(result.ToString());

/*
 * Console.Write 함수들은 매 출력마다 flush 연산을 수행한다.
 * 따라서, 위와 같은 반복문의 경우에는 StringBuilder에 출력 내용을 모아서 한 번에 처리하는 것이 더 나은 효율을 보인다.
 */