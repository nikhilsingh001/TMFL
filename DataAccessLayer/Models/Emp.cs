using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Employee")]
    public class Emp
    {
        [NotMapped]
        public int id { get; set; }
        public int EmpId { get; set; }
        public string? Emp_name { get; set; }
        public int Mobil_No { get; set; }
        public string? Email_Id { get; set; }
        public string? Gender { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string? Emp_Address { get; set; }
        public  int DesignationId { get; set; }
        public int Regionid { get; set; }
        public int Zoneid { get; set; }
        public int Branchid { get; set; }
       
       




    }
}
