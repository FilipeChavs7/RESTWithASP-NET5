using RESTWithASP_NET5.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        
        [Column("name_book")]
        public string NameBook { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("launch_date")]
        public DateTime DateLaunch { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
    }
}
