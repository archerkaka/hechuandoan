using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    class Rules
    {
        public List<string> NhomSuKien(string s)
        {
            string[] words = Regex.Split(s, "->");
            string[] a = Regex.Split(words[0], ",");
             
            List<string> list=new List<string>(a);
            return list;
        }
        public List<string> KetQua(string s)
        {
            string[] words = Regex.Split(s, "->");
            string[] a = Regex.Split(words[1], ",");

            List<string> list = new List<string>(a);
            return list;
        }
    }
}
