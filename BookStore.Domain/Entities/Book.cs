using System.Security.Cryptography.X509Certificates;

namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity<Guid>
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get; set; }
        public string Isbn { get; set; }
        public Publisher Publisher { get; set; }
        public Language Languages { get; set; }
        public IList<Format> Formats { get; set; }
        public IList<Review> Reviews { get; set; }
    }
}
 