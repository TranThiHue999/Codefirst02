using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Codefirst02.Models
{
    public class AutoGenerateKey
    {
        public string GenerateKey ( string id )
        {
            string strkey ="";

            string numPart ="", strPart = "";

            numPart = Regex.Match(id, @"\d+").Value;

            strkey = strPart + (Convert.ToInt32(numPart) +1);


    }
}