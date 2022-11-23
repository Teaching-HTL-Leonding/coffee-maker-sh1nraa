//Sinan Peherstorfer

const double TEA_PRICE = 1.50;
const double CAPP_PRICE = 3.50;
const double CACAO_PRICE = 2.50;

double money = 0;
double remainingMoney = 0;
double fiftyCent = 0;
double oneEuro = 0;
double twoEuro = 0;

Console.OutputEncoding = System.Text.Encoding.Default;

System.Console.WriteLine("Caffee Machine");
System.Console.WriteLine("===============");
System.Console.WriteLine();


System.Console.WriteLine("Please enter the amount of money you fed into the machine (multiple of 0.5€)");
money = double.Parse(Console.ReadLine()!);


System.Console.WriteLine();

Console.WriteLine("Which product would you like to buy?");


int choice = 0;
do
{
    Console.WriteLine("1) Cappuccino (3.5€), 2) Tea (1.5€), 3) Cacao (2.5€), 4) Nothing else");
    choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {

        case 1:
            money = money - CAPP_PRICE;
            if (money < 1.50)
            {
                System.Console.WriteLine("Sorry, you do not have enough credit left");
                money = money + CAPP_PRICE;
            }
            break;

        case 2:
            money = money - TEA_PRICE;
            if (money < 1.50)
            {
                System.Console.WriteLine("Sorry, you do not have enough credit left");
                money = money + CAPP_PRICE;
            }
            break;

        case 3:
            money = money - CACAO_PRICE;
            if (money < 1.50)
            {
                System.Console.WriteLine("Sorry, you do not have enough credit left");
                money = money + CAPP_PRICE;
            }
            break;
    }
} while (choice != 4);


System.Console.WriteLine($"You get {money} back.");

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