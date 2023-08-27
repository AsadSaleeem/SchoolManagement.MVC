using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.MVC.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
         
        public string Name { get; set; }    

        public int Code { get; set; }

        public int Credits { get; set; }


    }
}
