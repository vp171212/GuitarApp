using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopApp.Model
{
    internal class Guitar
    {
        internal string serialNumber { get; }
        internal double price { get; set; }
        internal GuitarSpec spec { get; }

        public Guitar(string serialNumber,
                        double price,
                        GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }
    }
}
