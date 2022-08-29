using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TCM_Fortnite_Tool
{
    class Defaults
    {
        public static Regex REGEX = new Regex(@"\d{1,3}(\.\d{1,3}){3}:\d{1,5}");
        public static List<string> Sources = new List<string>();
    }
}
