using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst02.Models
{
    public class Employee: Person
    {
        public String Company { get; set; }
        public String Adress { get; set; }
    }
}