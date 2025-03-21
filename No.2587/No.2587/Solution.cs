using System.Collections.Generic;

int avg = 0;
List<int> list = new List<int>();

for(int i = 0; i < 5; i++)
{
    int input = int.Parse(Console.ReadLine());
    list.Add(input); 
    
    avg += input;
}
for (int i = 0;i < list.Count;i++)
{
    for (int j = 0;j < list.Count;j++)
    {
        if (list[i] > list[j])
        {
            int tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }
    }
}
Console.WriteLine(avg/5);
Console.WriteLine(list[2]);