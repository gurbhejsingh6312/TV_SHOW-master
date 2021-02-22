using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TV_SHOW.Models
{
    public class TVShow_TRP
    {
        [Key]
        public int Id { get; set; }
        public string Show_Name { get; set; }
        public string Channel_Name { get; set; }
        public string Producer_Name { get; set; }
        public decimal Show_TRP { get; set; }
    }
}
