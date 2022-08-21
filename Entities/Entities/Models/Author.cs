using System;

namespace Entities.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public DateTime DoB { get; set; }
    }
}