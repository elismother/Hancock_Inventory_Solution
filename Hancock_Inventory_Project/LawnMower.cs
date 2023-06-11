namespace Hancock_Inventory_Project
{
    internal class LawnMower : IShippable
    {
        private string _product = "Lawn Mower";
        private decimal _shipFee = 24m;

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