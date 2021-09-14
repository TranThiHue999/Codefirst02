using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirst02.Models
{
    [Table ("Students")]
    public class Student
    {
        [Key]
        [MinLength(5)]
        [Required(ErrorMessage = " StudentID is required")]
        public string StudentID { get; set; }
       
        [Required(ErrorMessage = "StudentName is required")]
        public string StudentName { get; set; }
       
        public string Address { get; set; }

    }
}