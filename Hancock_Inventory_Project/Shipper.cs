namespace Hancock_Inventory_Project
{
    internal class Shipper
    {
        readonly IShippable[] _shipment;

        public Shipper()
        {
            _shipment = new IShippable[10];
        }

        public string MainMenu()
        {
            return "1. Add a Bicycle to the shipment\n2. Add a Lawn Mower to the Shipment" +
                "\n3. Add a Baseball Glove to the shipment\n4. Add Crackers to the shipment" +
                "\n5. List Shipment Items\n6. Compute Shipping Charges\n";
        }

        public string ShipperMenuSelection(string userInput)
        {
            int indexSetter = ShipTotalCount();
            bool validSelection = int.TryParse(userInput, out int selection);

            if (validSelection == true && selection > 0 && selection < 7)
            {
                if (selection <= 4)
                {
                    if (indexSetter != 10)
                    {
                        Add(selection);
                        return "1 " + _shipment[indexSetter].Product + " added to shipment\nPress any key to return to menu\n";
                    }
                    else
                    {
                        return "Unable to add: Max 10 items met\n";
                    }
                }
                
                else if (selection == 5)
                {
                    string message = ShipmentManifest();
                    return message;
                }

                else if (selection == 6)
                {
                    string shipCost = ShippingCost().ToString("C");
                    return "Total shipping cost for this order is " + shipCost + "\n";
                }
            }
            return "Invalid input: Choices 1-6 only\n";
        }

        string ShipmentManifest()
        {
            int[] productCount = ProductCount();
            string[] productName = ProductName();
            string message = "Shipment Manifest:\n";

            for (int i = 0; i < productCount.Length; i++)
            {
                if (productCount[i] == 1 || productName[i] == "Crackers")
                {
                    message += productCount[i] + " " + productName[i] + "\n";
                }

                else if (productCount[i] > 1)
                {
                    message += productCount[i] + " " + productName[i] + "s\n";
                }
            }
            return message;
        }

        int ShipTotalCount()
        {
            int shipCount = 0;

            for (int i = 0; 0 < _shipment.Length;i++)
            {
                if (shipCount == 10)
                {
                    return shipCount;
                }

                else if (_shipment[i] == null)
                {
                    return shipCount;
                }

                shipCount++;
            }
            return shipCount;
        }

        decimal ShippingCost()
        {
            decimal shippingCost = 0;

            for (int i = 0; i < _shipment.Length; i++)
            {
                if (_shipment[i] != null)
                {
                    shippingCost += _shipment[i].ShipFee;

                    if (_shipment[^1] == _shipment[i])
                    {
                        return shippingCost;
                    }
                }

                else
                {
                    return shippingCost;
                }
            }
            return shippingCost;
        }

        string[] ProductName()
        {
            string[] productName = new string[4];

            for (int i = 0; i < _shipment.Length; i++)
            {
                for (int ii = 0; ii < productName.Length; ii++)
                {
                    if (_shipment[i] == null)
                    {
                        break;
                    }

                    if (productName[ii] == _shipment[i].Product)
                    {
                        break;
                    }

                    else if (productName[ii] == null)
                    {
                        productName[ii] = _shipment[i].Product;
                        break;
                    }
                }
            }
            return productName;
        }

        int[] ProductCount()
        {
            string[] crossProduct = ProductName();
            int[] productCount = new int[4];

            for (int i = 0; i < crossProduct.Length; i++)
            {
                for (int ii = 0; ii < _shipment.Length; ii++)
                {
                    if (_shipment[ii] == null)
                    {
                        break;
                    }

                    if (crossProduct[i] == _shipment[ii].Product)
                    {
                        productCount[i]++;
                    }
                }
            }
            return productCount;
        }

        void Add(int selection)
        {
            int shipTotalCount = ShipTotalCount();
            if (selection == 1)
            {
                _shipment[shipTotalCount] = new Bicycle();
            }

            else if (selection == 2)
            {
                _shipment[shipTotalCount] = new LawnMower();
            }

            else if (selection == 3)
            {
                _shipment[shipTotalCount] = new BaseballGlove();
            }

            else if (selection == 4)
            {
                _shipment[shipTotalCount] = new Crackers();
            }
        }
    }
}