using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_Restoran
{
    class ProductItem
    {
        public string Name { get; set; }
        public byte Count { get; set; }
        public double Price { get; set; }
    }
    class Basket
    {
        public ArrayList OrderedProducts = new ArrayList();
    }
}
