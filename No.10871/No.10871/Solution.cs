string[] inputs = Console.ReadLine().Split();
int n = int.Parse(inputs[0]);
int x = int.Parse(inputs[1]);

string[] arrNums = Console.ReadLine().Split();

string result = "";

for (int i = 0; i < n; i++)
{
    if (int.Parse(arrNums[i]) < x)
    {
        result += arrNums[i] + " ";
    }
}

Console.WriteLine(result);



//string[] inputs = Console.ReadLine().Split();
//int n = int.Parse(inputs[0]);
//int x = int.Parse(inputs[1]);

//string[] arrNums = Console.ReadLine().Split();

//int[] arr = new int[n];

//for (int i = 0; i < arrNums.Length; i++)
//{
//    arr[i] = int.Parse(arrNums[i]);
//}

//string result = "";

//for (int i = 0; i < n; i++)
//{
//    if (arr[i] < x)
//    {
//        result += arr[i].ToString() + " ";
//    }
//}

//Console.WriteLine(result);