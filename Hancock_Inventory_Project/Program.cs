// Brittany Hancock
// IT 112
// NOTES: none
// BEHAVIORS NOT IMPLEMENTED AND WHY: Product objects created in
// class Shipper method, not in class Program directly.
namespace Hancock_Inventory_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new();
            string userInput;
            string shipperMessage;

            do
            {
                shipperMessage = shipper.MainMenu();
                Console.WriteLine(shipperMessage);
                userInput = Console.ReadLine();
                
                if (!String.IsNullOrEmpty(userInput))
                {
                    shipperMessage = shipper.ShipperMenuSelection(userInput);
                    Console.Clear();
                    Console.WriteLine(shipperMessage);
                    if (shipperMessage.Contains("menu"))
                    {
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                }
            } while (true);
        }
    }
}