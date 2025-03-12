    Random dice = new Random();
    int dice1 = dice.Next(1, 7);
    int dice2 = dice.Next(1, 7);
    int dice3 = dice.Next(1, 7);
    
    int total = dice1 + dice2 + dice3;
    
    Console.WriteLine($"Dice dice roll roll {dice1} + {dice2} + {dice3} = {total}");
    
    if ((dice1 == dice2) || (dice2 == dice3) || (dice1 == dice3))

    /*Пояснюю, "||" це оператор "OR", який питає чи одна з умов true, якщо так то він виконає код в фігурних дужках нижче
       тут ми перевіряємо чи хоч одна пара кубиків однакова, якщо так то виконаємо код в фігурних дужках */

    if ((dice1 == dice2) && (dice2 == dice3))

    /* Пояснюю, && - це логічний оператор AND, який, по суті, означає
         "тільки якщо обидва вирази істинні, то і весь вираз істинний".
            Якщо умова if == True тоді виконується код в фігурних лапках нижче*/

    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }

    else // Якшо умова вище не виконалась, то виконається код в фігурних дужках нижче
    {
        Console.WriteLine("You diceed doubles! +2 bonus to total!");
        total += 2;
    }

    // Після перевірки OR, ми зробили каскад умов, таким чином ми зменшили код, але він все одно працює правильно
    if (total > 16)
    {
        Console.WriteLine("You win!");
    }
    
    if (total < 16)
    {
        Console.WriteLine("You lose!");
    }
    
    // Example with Sting
    
    string message = "The quick brown fox jumps over the lazy dog.";
    bool result = message.Contains("dog"); // тут ми перевіряємо чи є в стрічці слово "dog"
    Console.WriteLine(result);

    if (message.Contains("fox")) // тут ми перевіряємо чи є в стрічці слово "fox" якщо є, то результат буде true
    { // це Code block, який виконається якщо умова вище буде true
        Console.WriteLine("What does the fox say?");
    }
