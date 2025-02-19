int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int quarter = 0;
    int dime = 0;
    int nickel = 0;
    int penny = 0;
    int input = int.Parse(Console.ReadLine());

    while (input >= 25)
    {
        quarter++;
        input -= 25;
    }

    while (input >= 10)
    {
        dime++;
        input -= 10;
    }

    while (input >= 5)
    {
        nickel++;
        input -= 5;
    }

    while (input >= 1)
    {
        penny++;
        input -= 1;
    }
    Console.WriteLine($"{quarter} {dime} {nickel} {penny}");
}