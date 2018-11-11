using Simple_Word_Scraper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simple_Word_Scraper.Builders
{
    class ScrapeCriteriaBuilder
    {
        //set fields (props ScrapeCriteria class for reference)
        //public string Data { get; set; }
        //public string Regex { get; set; }
        //public RegexOptions RegexOption { get; set; }
        //public List<ScrapeCriteriaPart> Parts { get; set; }

        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaPart> _parts;

        //create Constructor with set defaults method
        public ScrapeCriteriaBuilder()
        {
            SetDefaults();

        }

        private void SetDefaults()
        {
            //put fields in method
            _data = string.Empty;
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        //create methods that allow the fields to be set. 
        public ScrapeCriteriaBuilder WithData (string data)
        {
            _data = data;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }

        public ScrapeCriteriaBuilder WithPart(ScrapeCriteriaPart scrapeCriteriaPart)
        {
            //you are adding to the list.
            _parts.Add(scrapeCriteriaPart);
            return this;
        }

        //define how you are going to build it
        public ScrapeCriteria Build()
        {
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = _data;
            scrapeCriteria.Regex = _regex;
            scrapeCriteria.RegexOption = _regexOption;
            scrapeCriteria.Parts = _parts;

            return scrapeCriteria;
        }
    }
}
