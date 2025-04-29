StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int m = int.Parse(sr.ReadLine());
int[] c = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

LinkedList<int> linkedList = new LinkedList<int>();

for(int i = 0; i < n; i++)
{
    if (a[i] == 0)
    {
        linkedList.AddLast(b[i]);
    }
}

for(int i = 0;i < m; i++)
{
    linkedList.AddFirst(c[i]);
    sw.Write(linkedList.Last.Value+" ");
    linkedList.RemoveLast();
}

sw.Flush();

//시간초과 코드

//int num = 0;
//int[] res = new int[m];

//for(int i =  0; i < m; i++)
//{
//    num = c[i];
//    for(int j = 0; j < n; j++)
//    {
//        if (a[j] == 0)
//        {
//            int tmp = b[j];
//            b[j] = num;
//            num = tmp;
//        }
//    }
//    sw.Write(num+" ");
//}

//sw.Flush();