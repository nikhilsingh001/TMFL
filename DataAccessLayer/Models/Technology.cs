using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Technology")]
    public  class Technology
    {
        [Key]
        public int Id { get; set; }
        public string? TechnologyName { get; set; }
    }
}
