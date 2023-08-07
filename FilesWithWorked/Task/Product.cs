namespace FilesWithWorked.Task
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Categores { get; set; }

        public Purchase Purchases { get; set; }

        public Product()
        {
            
        }
        public Product(int id, string name, Category category, Purchase purchase)
        {
            Id = id;
            Name = name;
            Categores = category;
            Purchases = purchase;
        }
    }
}
