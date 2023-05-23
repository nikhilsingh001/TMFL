using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("zone")]
    public  class Zone
    {
        public  int id { get; set; }

        public int RegionID { get; set; }

        public string? Zonename { get; set; }

    }
}
