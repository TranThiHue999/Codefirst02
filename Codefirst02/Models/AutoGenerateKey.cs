using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Codefirst02.Models
{
    public class AutoGenerateKey
    {
        public string GenerateKey(string id)
        {
            string strkey = "";
            string numpPart = "",
            strPart = "",
            strPhanSo = "";
            numpPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;

            int PhanSo = (Convert.ToInt32(numpPart) + 1);
            for (int i = 0; i < numpPart.Length - PhanSo.ToString().Length; i++)
            {
                strPhanSo += "0";
            }
            strPhanSo += PhanSo;
            //tách phần chữ
            strkey = strPart + strPhanSo;
            return strkey;
        }
    }
}