using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Designation")]
    public class Designation
    {
        public int ID { get; set; }
        public string? DesignationName { get; set; }
    }
}
