namespace Hancock_Inventory_Project
{
    internal class Bicycle : IShippable
    {
        private string _product = "Bicycle";
        private decimal _shipFee = 9.5m;

        public string Product
        {
            get
            {
                return _product;
            }
        }

        public decimal ShipFee
        {
            get
            {
                return _shipFee;
            }
        }
    }
}