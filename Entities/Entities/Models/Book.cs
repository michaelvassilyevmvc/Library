using System.Collections.Generic;

namespace Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public string Image { get; set; }

    }
}