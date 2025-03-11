
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);


Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


int first = 500;
int second = 600;
int bigest = Math.Max(first, second);

Console.WriteLine($"The bigests number is {bigest}");
