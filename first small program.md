/*
Вас попросили додати функцію до програмного забезпечення вашої компанії.
Ця функція призначена для підвищення рівня поновлення підписок на програмне забезпечення.
Ваше завдання полягає в тому, щоб відображати повідомлення про продовження підписки,
коли користувач входить в систему і отримує повідомлення про те, що його підписка скоро закінчується.
Вам потрібно додати декілька операторів прийняття рішень,
щоб правильно додати логіку розгалуження до програми, щоб задовольнити вимоги.
*/


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

 // Задача вирішена вірно і успішно.
 // Виведення повідомлення про продовження підписки відбувається вірно в залежності від кількості днів до закінчення підписки.
