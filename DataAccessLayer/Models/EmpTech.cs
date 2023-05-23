using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("EmpTech")]
  
    public  class EmpTech
    {
        [Key]
      
        public int id  { get; set; }
        public int EmpID { get; set; }
        public Int32 TechId { get; set; }
    }
}
