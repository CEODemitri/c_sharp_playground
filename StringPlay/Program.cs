// stores a single unicode character
char love = '❤';
char numeral = 'I';

Console.WriteLine(love);
Console.WriteLine(numeral);
Console.WriteLine(love.GetType());

// c# treats char as a numeric type
// this means you can do math with them
char nextNumeral = (char)(numeral + 1);
Console.WriteLine(nextNumeral);
Console.WriteLine((int)nextNumeral);

// special characters
char singleQuote = '\'';
char backslash = '\\';
char newLine = '\n';
char tab = '\t';
char unicodeChar = '\u2103'; // Celsius symbol
Console.WriteLine($" {singleQuote} {backslash} {newLine} {tab} {unicodeChar}");

// checking char type | char class methods
Console.WriteLine(char.IsLetter(unicodeChar)); // false
Console.WriteLine(char.IsDigit(numeral)); // false
Console.WriteLine(char.IsWhiteSpace(tab)); // true
Console.WriteLine(char.IsPunctuation(singleQuote)); // true
Console.WriteLine(char.IsSymbol(love)); // true
Console.WriteLine(char.IsUpper(numeral)); // true
Console.WriteLine(char.IsLower(numeral)); // false

// challenge
// detect char type from user input
Console.Write("Enter a letter, number or symbol: ");
char userChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (char.IsLetter(userChar))
{
    Console.WriteLine($"{userChar} is a vowel: {"aeiouAEIOU".Contains(userChar)}");
    if (char.IsUpper(userChar))
    {
        Console.WriteLine($"{userChar} is uppercase.");
    }
    else
    {
        Console.WriteLine($"{userChar} is lowercase.");
    }
}
else if (char.IsDigit(userChar))
{
    Console.WriteLine($"{userChar} is a number.");
}
else if (char.IsWhiteSpace(userChar))
{
    Console.WriteLine("You entered a whitespace character.");
}
else if (char.IsPunctuation(userChar))
{
    Console.WriteLine($"{userChar} is a punctuation mark.");
}
else if (char.IsSymbol(userChar))
{
    Console.WriteLine($"{userChar} is a symbol.");
}
else
{
    Console.WriteLine("Unrecognized character type.");
}

// next-up : make a loop that prints all characters from A to Z
for (char start = 'A'; start  <= 'Z'; start++) 
{ 
    Console.WriteLine($"Current iteration: {start}");
}

// a - z
for (char lowerStart = 'a'; lowerStart <= 'z'; lowerStart++)
{
    Console.WriteLine($"Iteration : {lowerStart}");
}
