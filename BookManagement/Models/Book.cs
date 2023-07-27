namespace BookManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public string Publication { get; set; }

        public char BookType { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        public Book(int id, string name, string author, float price, string publication, char bookType, DateTime created, DateTime updated)
        {
            Id = id;
            Name = name;
            Author = author;
            Price = price;
            Publication = publication;
            BookType = bookType;
            Created = created;
            Updated = updated;
        }

        public Book()
        { }
    }
}
