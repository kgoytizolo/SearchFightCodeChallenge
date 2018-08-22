using System;
using System.Collections.Generic;

namespace SearchFight.Models
{
    public class SearchResults
    {
        public List<ProgrammingLanguage> ProgrammingLanguageToSearch { get ; set; }
        public List<WebSearchEngine> SearchEnginesToCompare { get; set; }
    }
}
