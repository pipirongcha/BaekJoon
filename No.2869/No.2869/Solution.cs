string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int v = int.Parse(input[2]);

int res = ((v-a) / (a - b))+1;
int check = (v-a) % (a - b);

if (check == 0)
{
    Console.WriteLine(res);
}
else
{
    Console.WriteLine(res + 1);
}    