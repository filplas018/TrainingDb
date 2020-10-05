using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XOPOW.Models
{
    public class Morodec
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime Date { get; set; }
        public string LOLRank { get; set; }
        public string Address { get; set; }
        public string Term { get; set; }
    }
}
