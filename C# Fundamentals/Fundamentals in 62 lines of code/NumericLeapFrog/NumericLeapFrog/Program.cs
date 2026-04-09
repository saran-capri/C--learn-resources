int guessCount = 1;
int maxNumber = Random.Shared.Next(1, 50);//not inclusive of 50 1-49 only
int currentValue;
int guessIncrement;
bool validGuess;
//Number is 15
//Guess: 2(2), 3(5), 2(7)
Console.WriteLine("Numeric Leapfrog - A Number Guessing Game");
Console.WriteLine("Get close to the number without going over.");
Console.WriteLine("Each guess is added to the previous guess");
Console.WriteLine("When you are within three or you go over, the game is over");
Console.WriteLine("Get close in a few guesses as possible without going over.");
Console.WriteLine();
Console.Write("Please enter the starting number: ");
string startingNumberText = Console.ReadLine() ?? "1";
int.TryParse(startingNumberText, out currentValue);

//15 currentvalue(12) < maxnumber(15) - 3 
while (currentValue < maxNumber - 3)
{
    Console.WriteLine();//raw string literal """  lines of string"""
    Console.WriteLine(
        $"""
        You aren't there yet. Add another value to your
        current guess of {currentValue}. You have made 
        {guessCount} {(guessCount == 1 ? "guess" : "guesses")}.
        """);//string interpolation & inline if statement
    Console.WriteLine();
    guessCount++;

    do
    {
        Console.Write("Please enter a number to add to your guess:");
        string nextNumberText = Console.ReadLine() ?? "1";
        validGuess = int.TryParse(nextNumberText, out guessIncrement);
    } while (validGuess == false);


    currentValue += guessIncrement;

}

Console.WriteLine();
//15 <= 15
if (currentValue <= maxNumber)
{
    Console.WriteLine(
        $"""
        You win! The max number was {maxNumber} and you
        guessed {currentValue}. It only took you {guessCount}
        guesses.
        """);
}
else
{
    Console.WriteLine(
        $"""
        Sorry, you lost. The max number was {maxNumber} and you
        guessed {currentValue}. It took you {guessCount}
        guesses before you went over.
        """);
}

Console.ReadLine();
