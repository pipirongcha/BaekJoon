string target = Console.ReadLine();
List<string> ssList = new List<string>();

for (int i = 0; i < target.Length; i++)
{
    for (int j = 0; j < target.Length - i; j++)
    {
        ssList.Add(target.Substring(i, j + 1));
    }
}

ssList = ssList.Distinct().ToList();

Console.WriteLine(ssList.Count);