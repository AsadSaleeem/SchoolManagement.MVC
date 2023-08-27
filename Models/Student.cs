using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.MVC.Models
{
    public partial class Student
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Date { get; set; }  


    }
}
    