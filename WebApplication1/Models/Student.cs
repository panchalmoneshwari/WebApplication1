using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RollNo { get; set; }
        [Display(Name ="Student Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is Required")]
        [Range(minimum:18,maximum:60,ErrorMessage ="Age should be in Between 18-60")]
        public int Age { get; set; }
        [Required(ErrorMessage = "EmailId is Required")]
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email should be in proper format")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password,ErrorMessage ="Enter valid Password")]
        public string Password { get; set; }
    }
}