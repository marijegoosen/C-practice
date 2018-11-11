using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simple_Word_Scraper.Data
{
    class ScrapeCriteriaPart
    {
        //create 2 properties
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
    }
}
