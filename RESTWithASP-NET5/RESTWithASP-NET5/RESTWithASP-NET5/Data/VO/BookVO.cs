using RESTWithASP_NET5.Hypermedia;
using RESTWithASP_NET5.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string NameBook { get; set; }
        public string Author { get; set; }
        public DateTime DateLaunch { get; set; }
        public decimal Price { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
