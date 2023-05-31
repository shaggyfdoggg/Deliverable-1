// See https://aka.ms/new-console-template for more information
int sodaStock = 100;
int chipsStock = 40;
int candyStock = 60;
Console.WriteLine("Welcome to the restocking tool.");
Console.WriteLine($"\nHow many sodas have been sold today? {sodaStock} are in stock.");
string answerOne = Console.ReadLine();
int sodaSold = int.Parse(answerOne);
if (sodaSold > 100)
{
    Console.WriteLine("That number is too high. Do not adjust the stock.");
}
int currentSoda = sodaStock - sodaSold;
if (currentSoda <= 40 && currentSoda >= 0)
{
    Console.WriteLine("Time to restock");
    Console.WriteLine($"There are {currentSoda} sodas left.");
}

Console.WriteLine($"\nHow many chips have been sold today? {chipsStock} are in stock.");
string answerTwo = Console.ReadLine();
int chipsSold = int.Parse(answerTwo);
if (chipsSold > 40)
{
    Console.WriteLine("That number is too high. Do not adjust the stock.");
}
int currentChips = chipsStock - chipsSold;
if (currentChips <= 20 && currentChips >= 0)
{
    Console.WriteLine("Time to restock");
    Console.WriteLine($"There are {currentChips} chips left.");
}

Console.WriteLine($"\nHow many candies have been sold today? {candyStock} are in stock.");
string answerThree = Console.ReadLine();
int candySold = int.Parse(answerThree);
if (candySold > 60)
{
    Console.WriteLine("That number is too high. Do not adjust the stock.");
}
int currentCandy = candyStock - candySold;
if (currentCandy <= 40 && currentCandy >= 0)
{
    Console.WriteLine("Time to restock");
    Console.WriteLine($"There are {currentCandy} candiess left.");
}

Console.WriteLine("\nThank you for filling out the values. Here is what needs to be restocked:");
if (currentSoda <= 40 && currentSoda >= 0)
{
    Console.WriteLine("Sodas need to be restocked");
}
if (currentChips <= 20 && currentChips >= 0)
{
    Console.WriteLine("Chips need to be restocked");
}
if (currentCandy <= 40 && currentCandy >= 0)
{
    Console.WriteLine("Candy needs to be restocked");
}



