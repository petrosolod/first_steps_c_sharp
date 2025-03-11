Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration >= 10)
{
    if (daysUntilExpiration >= 10)
    discountPercentage +=5;
    Console.WriteLine($"Your subscription will expire soon.\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration >= 5)
{
    if (daysUntilExpiration >= 5)
    daysUntilExpiration += 10;
    Console.WriteLine($"Your subscription expires in 5 days!\nRenew now! and save {discountPercentage}%!");
}
else if(daysUntilExpiration == 1)
{
    if (daysUntilExpiration == 1)
    discountPercentage += 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}% !");
}
else
{
    Console.WriteLine("Your subscription has expired.");
}
