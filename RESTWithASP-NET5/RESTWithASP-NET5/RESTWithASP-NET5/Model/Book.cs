using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Model
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name_book")]
        public string NameBook { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("launch_date")]
        public string DateLaunch { get; set; }
        [Column("price")]
        public string Price { get; set; }
    }
}
