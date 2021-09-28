using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirst02.Models
{
    public class Employee: Person
    {
        public String Company { get; set; }
        [AllowHtml]
        public String Adress { get; set; }
    }
}