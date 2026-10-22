
Console.WriteLine("Enter a color");
Console.ReadLine();
string inputText = Console.ReadLine();
Random next = new Random();

if (inputText == "red")
{
    next.Next(1 + 2 - 100);
} else if (inputText == "black")
{
    next = new Random();
} else if (inputText == "color") 
{
    Console.WriteLine("Wrong color, enter the colors red or black if you want to play the game");
}

Console.WriteLine("Enter a number");
Console.ReadLine();
int number = 56;

if (number == 56)
{
    Convert.ToInt32(56 * 2);
} else if (number != 56)
{
    Console.WriteLine("No win for you");
}
