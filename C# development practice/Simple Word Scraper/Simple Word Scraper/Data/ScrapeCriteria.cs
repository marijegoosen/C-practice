using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simple_Word_Scraper.Data
{
    class ScrapeCriteria
    {
        //create Constructor
        //create Public properties

        public ScrapeCriteria()
        {
            //create new List for Parts
            Parts = new List<ScrapeCriteriaPart>();
        }

        public string Data { get; set; }
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
        public List <ScrapeCriteriaPart> Parts { get; set;}
        //create ScrapeCriterisPart as a class in Data folder.
    }
}
