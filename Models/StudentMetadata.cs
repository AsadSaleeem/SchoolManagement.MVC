using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.MVC.Models
{
    public class StudentMetadata
    {
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime Date { get; set; }
    }

    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student { }
}
