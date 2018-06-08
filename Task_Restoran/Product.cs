using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Restoran
{
    class Product
    {
        public string Name;
        public byte Count { get; set; }
        public double Price { get; set; }
        public Category Category { get;set; }

        public Product()
        {
            Count = 1;
            Price = 0;
        }

    }

}
