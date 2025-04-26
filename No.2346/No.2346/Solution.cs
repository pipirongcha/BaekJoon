StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
LinkedList<int[]> list = new LinkedList<int[]>();
int j = 0;
int tmp = 0;
for (int i = 1; i <= n; i++)
{
    list.AddLast(new int[] { i, nums[i - 1] });
}

for (int i = 0; i < n; i++)
{

    if (j >= 0)
    {
        tmp = nums[list.First.Value[0] - 1];
        sw.Write(list.First.Value[0] + " ");
        list.RemoveFirst();
    }
    else
    {
        tmp = nums[list.Last.Value[0] - 1];
        sw.Write(list.Last.Value[0] + " ");
        list.RemoveLast();
    }
    if (list.Last == list.First)
    {
        sw.Write(list.First.Value[0]);
        break;
    }
    if (tmp > 0)
    {
        j = 1;
        while (j != tmp)
        {
            list.AddLast(list.First.Value);
            list.RemoveFirst();
            j++;
        }
    }
    else
    {
        j = -1;
        while (j != tmp)
        {
            list.AddFirst(list.Last.Value);
            list.RemoveLast();
            j--;
        }

    }
}

sw.Flush();


//Deque를 쓰진 않지만, 더 빠르고 메모리를 덜 사용하는 코드

//StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
//int n = int.Parse(Console.ReadLine());
//int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//int pointer = 0


//for(int i = 0; i < nums.Length; i++) 
//{
//    int memo = nums[pointer];
//    sw.Write(pointer+1+" ");
//    if (i == nums.Length - 1)
//    {
//        break;
//    }
//    int moveCount = 0;
//    nums[pointer] = 0;
//    if (memo > 0)
//    {
//        while (moveCount != memo)
//        {
//            pointer++;
//            if (pointer >= nums.Length)
//            {
//                pointer = 0;
//            }
//            if (nums[pointer] != 0)
//            {
//                moveCount++;
//            }
//        }
//    }
//    else
//    {
//        while (moveCount != memo)
//        {
//            pointer--;
//            if (pointer < 0)
//            {
//                pointer = nums.Length-1;
//            }
//            if (nums[pointer] != 0)
//            {
//                moveCount--;
//            }

//        }
//    }
//}

//sw.Flush();
