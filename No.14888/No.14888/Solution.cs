StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(sr.ReadLine());
int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] op = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int min = int.MaxValue;
int max = int.MinValue;
int res = nums[0];

int plus = op[0];
int minus = op[1];
int multiple = op[2];
int divide = op[3];

List<char> tmp = new List<char>();
List<List<char>> operators = new List<List<char>>();

for (int i = 0; i < plus; i++)
{
    tmp.Add('+');
}

for (int i = 0; i < minus; i++)
{
    tmp.Add('-');
}

for (int i = 0; i < multiple; i++)
{
    tmp.Add('*');
}

for (int i = 0; i < divide; i++)
{
    tmp.Add('/');
}

Permutation(tmp, 0);


void Permutation(List<char> list, int depth)
{
    if (depth == list.Count - 1)
    {
        List<char> target = new List<char>();
        for(int i = 0; i < list.Count; i++)
        {
            target.Add(list[i]);
        }
        operators.Add(target);
        return;
    }

    for (int i = depth; i < list.Count; i++)
    {
        char c = list[i];
        list[i] = list[depth];
        list[depth] = c;
        Permutation(list, depth + 1);
        c = list[i];
        list[i] = list[depth];
        list[depth] = c;
    }
}

for (int i = 0; i < operators.Count; i++)
{
    res = nums[0];
    for (int j = 0; j < n-1; j++)
    {
        if (operators[i][j] == '+')
        {
            res += nums[j + 1];
        }
        else if (operators[i][j] == '-')
        {
            res -= nums[j + 1];
        }
        else if (operators[i][j] == '*')
        {
            res *= nums[j + 1];
        }
        else
        {
            if (res < 0)
            {
                res = -(Math.Abs(res) / nums[j + 1]);
            }
            else
            {
                res /= nums[j + 1];
            }
        }
    }
    if (res < min)
    {
        min = res;
    }
    if (res > max)
    {
        max = res;
    }
}
    sw.WriteLine(max);
    sw.WriteLine(min);

sw.Flush();