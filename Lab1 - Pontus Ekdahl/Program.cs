

//string exampleStr = "29535123p48723487597645723645";
//string userInput = exampleStr;
Console.WriteLine("Input anything: ");
string userInput = Console.ReadLine();

int subStrLength;	// variabel för att hålla koll på längden/antal karaktärer i substringen som ska markeras
long sum = 0;
Console.ForegroundColor = ConsoleColor.White; // för tydlighet

for (int i = 0; i < userInput.Length; i++)
{
	subStrLength = 1;
	for (int j = i + 1; j < userInput.Length; j++)
	{
		if (char.IsDigit(userInput[j]))	// om tecknet är en siffra
		{
			subStrLength++;
			if (userInput[j] == userInput[i])	// om likvärdigt tecken hittas
			{
				sum += Int64.Parse(userInput.Substring(i, subStrLength));

				Console.Write(userInput.Substring(0, i));

				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write(userInput.Substring(i, subStrLength));

				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(userInput.Substring(i + subStrLength, userInput.Length - i - subStrLength));
				break;
			}
		}
		else
		{
			break;
		}
	}
}
Console.WriteLine("");
Console.WriteLine($"Summan utav markerade tal är: {sum}");