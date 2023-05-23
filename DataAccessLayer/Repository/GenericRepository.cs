using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Models;
using DataAccessLayer.Repository.Contract;
using DataAccessLayer.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {

        private readonly DataContext.DataContext _dataContext;


        public GenericRepository(DataContext.DataContext dataContext)
        {
            _dataContext=dataContext;   
        }

        public string AddDoc(EmployeeDocument data)
        {
            try
            {
                _dataContext.Document.Add(data);
                _dataContext.SaveChanges();


                return "Added";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string AddEmp(Emp data)
        {
            try
            {
                _dataContext.emps.Add(data);
                _dataContext.SaveChanges ();

                return  "added";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddTech(EmpTech data)
        {
            _dataContext.Tech.Add(data);
            _dataContext.SaveChanges();
        }

        public  List<Designation> GetDesigna()
        {
            try
            {
                return  _dataContext.Designation.ToList();



            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EmployeeDocument> GetDocuments()
        {
            try
            {
                return _dataContext.Document.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  List<EmpTech> GetTech()
        {
            try
            {
                 return  _dataContext.Tech.ToList();

            }
            catch (Exception)
            {

                throw;
            } 
        }

        public List<Technology> GetTechnologies()
        {
            return _dataContext.Technologys.ToList();
        }

        List<Emp> IGenericRepository<TModel>.GetAllEmp()
        {

            try
            {

                return  _dataContext.emps.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

         List<Branch> IGenericRepository<TModel>.GetBranches(int? zoneid)
        {
            try
            {
                if (zoneid != null)
                {
                    return _dataContext.branches.Where(b => b.ZoneID == zoneid).ToList();
                }
                else {
                    return _dataContext.branches.ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        List<Designation> IGenericRepository<TModel>.GetDesigna()
        {
            try
            {
                return  _dataContext.Designation.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<Region> IGenericRepository<TModel>.GetRegion()
        {
            try
            {
                return  _dataContext.Regions.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<Zone> IGenericRepository<TModel>.GetZones(int? regionId)
        {
            try
            {
                if (regionId != null)
                {
                    return _dataContext.Zones.Where(b => b.RegionID == regionId).ToList();
                }
                else {
                    return _dataContext.Zones.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
