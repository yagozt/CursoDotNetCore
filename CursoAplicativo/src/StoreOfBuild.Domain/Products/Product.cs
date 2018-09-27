namespace StoreOfBuild.Domain.Products
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public Category Category { get; set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        public Product(string name, Category category, decimal price, int stockQuantity) 
        {
            setProperties(name, price, category, stockQuantity);
            validateValues(name, price, category, stockQuantity);
        }

        public Product()
        {
        }

        public void Update(string name, Category category, decimal price, int stockQuantity) 
        {
            setProperties(name, price, category, stockQuantity);
            validateValues(name, price, category, stockQuantity);
        }

        private void setProperties(string name, decimal price, Category category, int stockQuantity) 
        {
            this.Name = name;
            this.Price = price;
            this.StockQuantity = stockQuantity; 
            this.Category = category;
        }

        private void validateValues(string name, decimal price, Category category, int stockQuantity) 
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(category == null, "Category is required");
            DomainException.When(price < 0, "Price is required");
            DomainException.When(stockQuantity < 0, "Stock Quantity is required");               
        }
    }
}