namespace StoreOfBuild.Domain.Products
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category Category { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        public Product(string name, Category category, decimal price, int stockQuantity) 
        {
            setProperties(name, category, price, stockQuantity);
            validateValues(name, category, price, stockQuantity);
        }

        public void Update(string name, Category category, decimal price, int stockQuantity) 
        {
            setProperties(name, category, price, stockQuantity);
            validateValues(name, category, price, stockQuantity);
        }

        private void setProperties(string name, Category category, decimal price, int stockQuantity) 
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.StockQuantity = stockQuantity; 
        }

        private void validateValues(string name, Category category, decimal price, int stockQuantity) 
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(category == null, "Category is required");
            DomainException.When(price < 0, "Price is required");
            DomainException.When(stockQuantity < 0, "Stock Quantity is required");               
        }
    }
}