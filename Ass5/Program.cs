// Конвертер валют. У пользователя есть баланс в каждой из представленных валют. С помощью команд он может попросить сконвертировать одну валюту в другую. 
// Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент, когда решит пользователь.


double balance = ReadInt("Enter your balance amount in USD: ");
Console.Write("Enter the currency you would like to convert your balance to (RUB, CNY, USD) or exit to stop the program: ");
string input = Console.ReadLine();
bool isWork = true;
while (isWork)
{
    switch (input)
    {
        case "exit":
            isWork = false;
            break;
        case "RUB":
            balance = balance*59.90;
            Console.WriteLine(balance + " RUB");
            Console.Write("Enter the currency you would like to convert your balance to (USD, CNY): ");
            balance = balance/59.90;
            input = Console.ReadLine();
            break;
        case "CNY":
            balance = balance*6.82;
            Console.WriteLine(balance + " CNY");
            Console.Write("Enter the currency you would like to convert your balance to (RUB, USD): ");
            balance = balance/6.82;
            input = Console.ReadLine();
            break;
        case "USD":
            Console.WriteLine(balance + " USD");
            Console.Write("Enter the currency you would like to convert your balance to (RUB, USD): ");
            input = Console.ReadLine();
            break;
    }        
}

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

