using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    class TriThuc
    {
        public string SuKien(string s)
        {
            string[] words = Regex.Split(s, "->");
            return words[0];
        }
        public string TTSuKien(string s)
        {
            string[] words = Regex.Split(s, "->");
            return words[1];
        }
        public string TimTTSuKien(string s,string[] trithuc)
        {
            string kq="";
            foreach(string item in trithuc)
            {
                if (s == SuKien(item))
                {
                    kq = TTSuKien(item);
                    break;
                }
            }
            return kq;
        }
        public string TimSuKien(string s, string[] trithuc)
        {
            string kq = "";
            foreach (string line in trithuc)
            {
                if (s == TTSuKien(line))
                {
                    kq = SuKien(line);
                    break;
                }
            }
            return kq;
        }

    }
}
