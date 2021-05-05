using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class Toy
    {
        public static List<Toy> Toys = new List<Toy>();


        #region Props
        public decimal Price { get; set; }
        public string What { get; set; }
        public string Description { get; }
        #endregion

        public Toy(string name, decimal price)
        {
            What = name;
            Price = price;
            Description = $"{What} (${Price})";
        }

        #region Methods
        public void Buy()
            => Toys.Add(this);
        #endregion
    }
}
