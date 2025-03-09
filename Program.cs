Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine("rolled: " + roll);
if (roll == 5)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You lose!");
}