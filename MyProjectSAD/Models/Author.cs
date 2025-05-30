using System.ComponentModel.DataAnnotations;

namespace MyProjectSAD.Models
{
    public class Author
    {
        [Key]
        public int AuthorId {  get; set; }
        public string AuthorFname {  get; set; }
        public string AuthorLname {  get; set; }

    }
}
