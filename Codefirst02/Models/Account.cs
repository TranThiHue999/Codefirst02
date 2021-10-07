using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirst02.Models
{
    [Table("Account")]
    public class Account
    {

        [Required(ErrorMessage = "Tai Khoan Khong Chinh Xác")]
        [Key]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Tai Khoan Khong Chinh Xác")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(10)]
        public string RoleID { get; set; }
    }
}