int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> list = arr.ToList();
bool isPossible = true;
Stack<int> stack = new Stack<int>();

for(int i = 1; i <= arr.Length; i++)
{
    if (stack.Count != 0 && stack.Peek() == i)
    {
        stack.Pop();
    }
    else
    {
        if (list.Count != 0)
        {
            while (list.Count != 0)
            {
                if (list[0] == i)
                {
                    list.RemoveAt(0);
                    break;
                }
                else
                {
                    stack.Push(list[0]);
                    list.RemoveAt(0);
                }
            }
        }
        else
        {
            isPossible = false;
            break;
        }
    }

}

if (isPossible)
{
    Console.WriteLine("Nice");
}
else
{
    Console.WriteLine("Sad");
}