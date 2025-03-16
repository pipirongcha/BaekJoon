string input = Console.ReadLine();
int n = int.Parse(input);
int tmp = 0;
bool done = false;

for (int i = 1; i < n; i++)
{
    string a = i.ToString();
    for (int j = 0; j < a.Length; j++)
    {
        tmp += a[j] - 48;
    }
    int res = i + tmp; 
    if (res == n)
    {
        Console.WriteLine(i);
        done = true;
        break;
    }
    tmp = 0;
}

if(!done)
{
    Console.WriteLine(0);
}
