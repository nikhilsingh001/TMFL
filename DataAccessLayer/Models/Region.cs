using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Region")]
    public class Region
    {
        public int ID { get; set; }

        public string Regionname { get; set; }
    }
}
