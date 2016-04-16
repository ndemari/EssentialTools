using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private IValueCalculator _calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            _calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalcProductTotal()
        {
            return _calc.ValueProducts(Products);
        }
    }
}
