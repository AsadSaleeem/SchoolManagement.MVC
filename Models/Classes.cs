using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.MVC.Models
{
    public class Classes
    {
        public int Class_Id { get; set; }


        [ForeignKey("Lecture Id")]
        public virtual int Id { get; set; }

        public virtual Lectures Lectures { get; set; }

        [ForeignKey("Course Id")]
        public virtual int CourseId {get;set; }
        public virtual Courses Courses { get; set; }    




    }
}
