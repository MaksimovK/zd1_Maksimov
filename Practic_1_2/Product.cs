namespace Practic_1_2
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetInfo()
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}