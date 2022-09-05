

string exampleStr = "29535123p48723487597645723645";

Console.WriteLine("Input anything: ");
//string userInput = Console.ReadLine();
string userInput = exampleStr;
int subStrLength;
bool isValid;
long sum = 0;
Console.ForegroundColor = ConsoleColor.White;

for (int i = 0; i < userInput.Length; i++)
{
	subStrLength = 1;
	isValid = false;
	for (int j = i + 1; j < userInput.Length; j++)
	{
		if (char.IsDigit(userInput[j]))
		{
			subStrLength++;
			if (userInput[j] == userInput[i])
			{
				isValid = true;
				break;
			}
		}
		else
		{
			break;
		}
	}
	if (isValid)
	{
		sum += Int64.Parse(userInput.Substring(i, subStrLength));
		Console.Write(userInput.Substring(0, i));
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Write(userInput.Substring(i, subStrLength));
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine(userInput.Substring(i + subStrLength, userInput.Length - i - subStrLength));
	}
}
Console.WriteLine("");
Console.WriteLine($"Summan utav markerade tal är: {sum}");