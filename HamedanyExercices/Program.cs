Console.WriteLine("please enter a number from 1 to 10");

int userInput = int.Parse(Console.ReadLine());

if(userInput >0 && userInput < 10)
{
    Console.WriteLine("the number is valid");
}
else
{
    Console.WriteLine("the number is not valid");
}