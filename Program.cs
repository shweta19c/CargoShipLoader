namespace CargoShipLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");

            Ship myCargoShip = new Ship();
            myCargoShip.TrainCarCount = 8;
            myCargoShip.CycleCount = 10;
            Console.WriteLine("This ship is " + myCargoShip.ToString());
            */
            Ship ship = new Ship();

            string WelcomeMessage = "Welcome to the cargo Ship. The goal of this game is to load the ship to its maximum capacity by adding motor cycles, cars, trucks, and train cars. A cycle takes 3 units of weight. A car takes 5 units of weight. A truck takes 19 units of weight. A train car takes 47 units of weight.";

            Console.WriteLine(WelcomeMessage);

            //repeat until the player gets the ship loaded to capacity
            while (ship.Capacity != ship.getShipLoad())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The ship capacity is "+ ship.Capacity);
                Console.ForegroundColor= ConsoleColor.White;

                Console.WriteLine("The ship has " + ship.CycleCount + " Motorcycles on board");
                Console.WriteLine("The ship has " + ship.CarCount + " Cars on board");
                Console.WriteLine("The ship has " + ship.TruckCount + " Trucks on board");
                Console.WriteLine("The ship has "+ ship.TrainCarCount + " Trains on board");

                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("The ship currently has " + ship.getShipLoad() + " total units on board");
                Console.ForegroundColor= ConsoleColor.White;

                int x;
                Console.WriteLine("How many motorcycles would you like to put on the ship?");
                x = int.Parse( Console.ReadLine());

                ship.CycleCount = x;

                Console.WriteLine("How many Cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.CarCount = x;

                Console.WriteLine("How many Trucks would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.TruckCount = x;

                Console.WriteLine("How many Trains would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.TrainCarCount = x;

                Console.WriteLine("The ship now has "+ ship.getShipLoad()+ " total units of weight on board");
                if(ship.overUnder() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The ship still has a room to spare. Load more items.");
                }
                if (ship.overUnder() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship is overloaded. Take some items off!");
                }
                Console.ForegroundColor=ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You loaded the ship successfully!");

            Console.ReadLine();
        }
    }
}
