float totalCredit = 0; 
float totalScore = 0;
Dictionary<string, float> grade = new Dictionary<string, float>
{
    {"A+",4.5f},
    {"A0",4.0f},
    {"B+",3.5f},
    {"B0",3.0f},
    {"C+",2.5f},
    {"C0",2.0f},
    {"D+",1.5f},
    {"D0",1.0f},
    {"F",0.0f }
};

for (int i = 0; i < 20; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    if (input[2] != "P")
    {
        totalCredit += float.Parse(input[1]);
        totalScore += float.Parse(input[1])*grade[input[2]];
    }

}

Console.WriteLine(totalScore/totalCredit); 

