namespace StoreOfBuild.Domain.Products
{
    public class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name) 
        {
            validadeNameAndSetName(name);
        }

        public void Update(string name)
        {
            validadeNameAndSetName(name);
        }

        private void validadeNameAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(name.Length < 3, "Name invalid");
            this.Name = name;
        }
    }
}