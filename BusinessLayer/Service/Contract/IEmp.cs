using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Models;
using System.Web.Mvc;

namespace BusinessLayer.Service.Contract
{
    public   interface IEmp
    {
        List<Emp> GetEmps();

        string AddEmp(Emp data);

        List<Designation> GetDesignations();
        List<Region>  GetRegions();
        List<Zone> GetZones(int? Regid=null);
        List<Branch> GetBranch(int? Zoneid = null);
        List<Technology> Technologies();

        string Adddoc(EmployeeDocument data);

        void AddTech(EmpTech data);
        List<EmployeeDocument> Doclist();

        List<EmpTech> techlist();
    }
}
