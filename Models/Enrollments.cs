using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.MVC.Models
{
    public class Enrollments
    {
        public int Enroll_Id { get; set; }


        [ForeignKey("Student Id")]
        public virtual int Id { get; set; }

        public virtual Student Students { get; set; }


        [ForeignKey("Class Id")]
        public virtual int ClassId { get; set; }
        public virtual Classes Class { get; set; }

        public string Grades { get; set; }



    }
}
