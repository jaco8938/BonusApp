using System;
using System.Collections.Generic;
using System.Text;

namespace BonusApp
{
    public class Order
    {
        public List<Product> products = new List<Product>();
        public DG_BonusProvider Bonus { get; set; }
        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double amount = 0;
            foreach (var item in products)
            {
                amount += item.Value;
            }
            return amount;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
