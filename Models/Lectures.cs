using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.MVC.Models
{
    public class Lectures
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
