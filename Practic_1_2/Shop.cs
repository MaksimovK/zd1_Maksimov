using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practic_1_2
{
    public class Shop
    {
        private Dictionary<Product, int> products;

        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }

            return null;
        }

        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }

        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }

        public string WriteAllProducts()
        {
            string info = "Список продуктов: ";
            foreach (var product in products)
            {
                info += "\n" + product.Key.GetInfo() + "; Количество: " + product.Value;
            }

            return info;
        }

        public void Sell(Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!");
                }
                else
                {
                    products[product]--;
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
    }
}