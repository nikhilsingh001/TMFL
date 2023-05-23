using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presentation_Layer__UI_.ViewModels
{
    public class ViewModel

    {


        public int EmpId { get; set; }
        public string? Emp_name { get; set; }
        public string? Emp_Address { get; set; }
        public int Mobil_No { get; set; }
        public string? Email_Id { get; set; }
        public string? Gender { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string? DesignationName { get; set; }
        public string? Regionname { get; set; }
        public string? Zonename { get; set; }
        public string? BranchName { get; set; }
        public string? DocumentName { get; set; }


    }
}
