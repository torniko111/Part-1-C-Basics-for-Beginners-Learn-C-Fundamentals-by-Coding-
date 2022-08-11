Console.WriteLine("enter speedlimit");

int speedLimit = int.Parse(Console.ReadLine());

Console.WriteLine("enter the car speed");

int carSpeed = int.Parse(Console.ReadLine());

int difference = carSpeed - speedLimit;

int points = 100;

if (difference < 0)
{
    Console.WriteLine("ok");
}
else if (difference <= 5)
{
    Console.WriteLine("cutted points : {0}", difference);
}
else
{
    Console.WriteLine("license suspendend");
}