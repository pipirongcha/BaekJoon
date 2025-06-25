using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();
int n = int.Parse(sr.ReadLine());

bool heart = false;
bool waist = false;
bool armL = false;
bool armR = false;
bool legL = false;
bool legR = false;

int[] heartPos = new int[2];
int tmp = 0;
int tmp2 = 0;
int[] legPos = new int[2];

for (int i = 0; i < n; i++)
{
    string input = sr.ReadLine();
    for(int j = 0; j < n; j++)
    {
        if(!heart && input[j] == '*')
        {
            heart = true;
            heartPos[0] = i + 2;
            heartPos[1] = j + 1;
            sb.AppendLine($"{heartPos[0]} {heartPos[1]}");
            break;
        }
        else if(!armL)
        {
            if(j == heartPos[1]-1)
            {
                sb.Append($"{tmp} ");
                armL = true;
                tmp = 0;
            }
            else if (input[j] == '*')
            {
                tmp++;
            }
        }
        else if(!armR)
        {
            if (j == n - 1 && input[j] == '*')
            {
                tmp++;
                sb.Append($"{tmp} ");
                armR = true;
                tmp = 0;
                break;
            }
            else if (input[j] != '*')
            {
                sb.Append($"{tmp} ");
                armR = true;
                tmp = 0;
                break;
            }
            else
            {
                tmp++;
            }
        }
        else if(!waist)
        {
            if (j == heartPos[1] - 1 && input[j] == '*')
            {
                tmp++;
            }
            else if(j == heartPos[1] -1 && input[j] != '*')
            {
                sb.Append($"{tmp} ");
                waist = true;
                legPos[0] = j - 1;
                legPos[1] = j + 1;
                tmp = 1;
                tmp2 = 1;
                break;
            }
        }
        else
        {
            if(j == legPos[0] && input[j] ==  '*')
            {
                tmp++;
            }
            if(j == legPos[1] && input[j] == '*')
            {
                tmp2++;
            }
        }
    }
}
sb.Append($"{tmp} {tmp2}");
Console.WriteLine(sb.ToString());