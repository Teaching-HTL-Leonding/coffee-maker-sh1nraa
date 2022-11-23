//Sinan Peherstorfer
//Bonus

const decimal TEA_PRICE = 1.50m;
const decimal CAPP_PRICE = 3.50m;
const decimal CACAO_PRICE = 2.50m;

decimal money = 0;
decimal remainingMoney = 0;
decimal fiftyCent = 0;
decimal oneEuro = 0;
decimal twoEuro = 0;

Console.OutputEncoding = System.Text.Encoding.Default;

System.Console.WriteLine("Caffee Machine");
System.Console.WriteLine("===============");
System.Console.WriteLine();


do
{
    System.Console.WriteLine("Please enter the amount of money you fed into the machine (multiple of 0.5€)💰");
    money = decimal.Parse(Console.ReadLine()!);

    if (money % 0.5m != 0)
    {
        System.Console.WriteLine("This money amount is not avaiable - try again");
    }
} while (money % 0.5m != 0);

System.Console.WriteLine();

Console.WriteLine("Which product would you like to buy?☕");


int choice = 0;
do
{
    Console.WriteLine("1) Cappuccino (3.5€), 2) Tea (1.5€), 3) Cacao (2.5€), 4) Nothing else");
    choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {

        case 1:
            money = money - CAPP_PRICE;
            break;

        case 2:
            money = money - TEA_PRICE;
            break;

        case 3:
            money = money - CACAO_PRICE;
            break;
    }
} while (money > TEA_PRICE && choice != 4);


System.Console.WriteLine($"You get {money} back.💱");

remainingMoney = Math.Floor(money);
money = money - remainingMoney;

while (remainingMoney > 0)
{
    if (remainingMoney % 2 == 0)
    {
        twoEuro++;
        remainingMoney -= 2;
    }
    else
    {
        oneEuro++;
        remainingMoney -= 1;
    }
}

System.Console.WriteLine($"You get {twoEuro}x2€ pieces");
System.Console.WriteLine($"You get {oneEuro}x1€ pieces");

if (money > 0)
{
    fiftyCent += 1;
    System.Console.WriteLine($"You get {fiftyCent}x0.5€ pieces");
}