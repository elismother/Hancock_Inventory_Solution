namespace Hancock_Inventory_Project
{
    internal class BaseballGlove : IShippable
    {
        private string _product = "Baseball Glove";
        private decimal _shipFee = 3.23m;

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