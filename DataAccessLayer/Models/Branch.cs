using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Models
{
    [Table("Branch")]
    public class Branch
    {
        public int ID { get; set; }

        public int ZoneID { get; set; }

        public string? BranchName { get; set; }
    }
}
