namespace Hancock_Inventory_Project
{
    internal class Crackers : IShippable
    {
        private string _product = "Crackers";
        private decimal _shipFee = .57m;

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