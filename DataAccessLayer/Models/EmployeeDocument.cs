using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("EmployeeDocument")]
    public class EmployeeDocument
    {
        public int id { get; set; }
        public string? DocumentName { get; set; }

        public int EmpId { get; set; }

        public string? DocPath { get; set; }
    }
}
