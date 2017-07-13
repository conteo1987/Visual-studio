using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wild_farm.Models
{
    public abstract class Food
    {
        protected Food(int qty)
        {
            this.Quantity = qty;
        }

        public int Quantity { get; set; }
    }
}
