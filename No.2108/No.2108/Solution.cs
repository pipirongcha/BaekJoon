StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(sr.ReadLine());
int[] arr = new int[n];
int min = 4001;
int max = -4001;
double avg = 0;

for (int i = 0; i < n; i++)
{
    int target = int.Parse(sr.ReadLine());

    avg += target;
    
    if (target < min)
    {
        min = target;
    }
    if (target > max)
    {
        max = target;
    }

    arr[i] = target;

}

avg = Math.Round(avg / n, 0);
if (avg == -0)
{
    avg = 0;
}

Array.Sort(arr);

int count = 1;
int firstCount = 0;
int firstMode = 0;
int secondMode = 0;
int secondCount = 0;

if (n == 1)
{
    secondMode = arr[0];
}

for (int i = 0; i < n-1; i++)
{
    if(arr[i] == arr[i+1])
    {
        count++;
    }
    else
    {
        count = 1;
    }

    if(firstCount == count)
    {
        if (secondCount < count)
        {
            secondCount = count;
            secondMode = arr[i];
        }
    }
    if (firstCount < count)
    {
        secondMode = firstMode;
        secondCount = firstCount;
        firstCount = count;
        firstMode = arr[i];

    }

}

if (secondCount == firstCount)
{
    firstMode = secondMode;
}

sw.WriteLine(avg);
sw.WriteLine(arr[n / 2]);
sw.WriteLine(firstMode);
sw.WriteLine(max - min);
sw.Flush();
