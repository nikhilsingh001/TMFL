using BusinessLayer.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.DataContext;
using DataAccessLayer.Models;
using DataAccessLayer.Repository.Contract;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.VisualBasic;
using System.Web.Mvc;

namespace BusinessLayer.Service
{
    public class ServiceEmp : IEmp
    {

        private readonly IGenericRepository<Emp> _repository;

        public ServiceEmp(IGenericRepository<Emp> repository)
        {
            _repository = repository;
        }

        public string Adddoc(EmployeeDocument data)
        {
            _repository.AddDoc(data);
            return "";
        }

        public string AddEmp(Emp data)
        {
            try
            {
                return _repository.AddEmp(data);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddTech(EmpTech data)
        {
             _repository.AddTech(data); 
        }

        public List<EmployeeDocument> Doclist()
        {
            try
            {
                return _repository.GetDocuments().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Branch> GetBranch(int? Zoneid = null)
        {
            try
            {
                return _repository.GetBranches(Zoneid);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Designation> GetDesignations()
        {
            try
            {
                return _repository.GetDesigna();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Emp> GetEmps()
        {
            try
            {

                return _repository.GetAllEmp();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Region> GetRegions()
        {
            try
            {
                return _repository.GetRegion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Zone> GetZones(int? Regid = null)
        {
            try
            {
                return _repository.GetZones(Regid);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EmpTech> techlist()
        {
            try
            {
                return _repository.GetTech();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Technology> Technologies()
        {
            try
            {
                return _repository.GetTechnologies();

            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
    

    
   

