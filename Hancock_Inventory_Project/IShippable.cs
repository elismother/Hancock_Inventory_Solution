using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hancock_Inventory_Project
{
    internal interface IShippable
    {
        string Product { get; }

        decimal ShipFee { get; }
    }
}
