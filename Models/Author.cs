using System.ComponentModel.DataAnnotations.Schema;

namespace Nagy_Gergo_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get => $"{FirstName} {LastName}"; set => FullName = value; }
    }
}
