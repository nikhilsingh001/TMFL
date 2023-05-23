using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DataAccessLayer.Repository.Contract
{
    public interface IGenericRepository<TModel> where TModel : class
    {

         List<Emp> GetAllEmp(); 
        List<Designation> GetDesigna();

        string AddEmp( Emp data);

        List<Region> GetRegion();

        List<Zone> GetZones(int? regionId);

        List<Branch> GetBranches(int? zoneid);

        List<Technology> GetTechnologies();

        List<EmployeeDocument> GetDocuments();
        string AddDoc(EmployeeDocument data);
        void AddTech(EmpTech data);

        List<EmpTech> GetTech();
    }
}
