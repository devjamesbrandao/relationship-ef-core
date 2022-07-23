namespace EFCoreRelationshipsTutorial.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}