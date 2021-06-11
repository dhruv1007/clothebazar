using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazar.enti
{
    public class Product : Baseenti
    {
        public Catagory catagory { get; set; }
        
        public decimal Price { get; set; }
        
    }
}
