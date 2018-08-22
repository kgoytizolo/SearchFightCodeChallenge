using System;

namespace SearchFight.Models
{
    public class WebSearchEngine
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public string QueryStringRestRequest { get; set; }
    }
}