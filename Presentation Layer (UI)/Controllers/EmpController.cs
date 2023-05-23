using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;

using BusinessLayer.Service.Contract;

using Microsoft.Extensions.FileProviders;
using System.Data;

using ClosedXML.Excel;

using System.Reflection;
using DocumentFormat.OpenXml.Office.CoverPageProps;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;

namespace Presentation_Layer__UI_.Controllers
{
    public class EmpController : Controller
    {
        private readonly IEmp _emp;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public EmpController(IEmp context, IWebHostEnvironment hostingEnvironment)
        {
            _emp = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {




            ViewBag.Tech = _emp.Technologies();




            return View();

        }

        public JsonResult Designations()
        {

            var data = _emp.GetDesignations();
            return new JsonResult(data);
        }

        public JsonResult Region()
        {

            var data = _emp.GetRegions();
            return new JsonResult(data);
        }

        public JsonResult ZOne(int id)
        {

            var data = _emp.GetZones(id);
            return new JsonResult(data);
        }

        public JsonResult branch(int id)
        {

            var data = _emp.GetBranch(id);
            return new JsonResult(data);
        }

        public IActionResult Empdata(IFormCollection Data)
        {
            try
            {



                Emp emp = new Emp();
                EmployeeDocument empdoc;
                EmpTech tech;

                emp.EmpId = Convert.ToInt32(Data["Empid"]);
                emp.Emp_name = Data["Empname"];
                emp.Emp_Address = Data["Address"];
                emp.Gender = Data["Gender"];
                emp.Email_Id = Data["Email"];
                emp.Date_of_Birth = Convert.ToDateTime(Data["DateOFBirth"]);
                emp.DesignationId = Convert.ToInt32(Data["IdDesc"]);
                emp.Regionid = Convert.ToInt32(Data["IdRegio"]);
                emp.Zoneid = Convert.ToInt32(Data["Idzone"]);
                emp.Branchid = Convert.ToInt32(Data["IdBranch"]);
                emp.Mobil_No = Convert.ToInt32(Data["Mobile_no"]);
                _emp.AddEmp(emp);

                foreach (var item in Data["ListTech"])
                {
                    tech = new EmpTech();
                    tech.TechId = Convert.ToInt32(item);
                    tech.EmpID = emp.EmpId;

                    _emp.AddTech(tech);



                }

                List<IFormFile> file = Data.Files.ToList();

                foreach (var item in file)
                {
                    empdoc = new EmployeeDocument();
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "File")).Root + $@"\{item.FileName.Trim().TrimEnd().TrimEnd()}";
                    var filedatabase = Path.Combine("wwwroot", "File") + $@"\{item.FileName.Trim().TrimEnd().TrimEnd()}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        item.CopyTo(fs);

                    }
                    empdoc.DocPath = filedatabase;
                    empdoc.DocumentName = item.FileName;
                    empdoc.EmpId = emp.EmpId;
                    _emp.Adddoc(empdoc);
                }

            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Getdata()
        {

            var listdata = (from emp in _emp.GetEmps()
                            join d in _emp.GetDesignations() on emp.DesignationId equals d.ID
                            join z in _emp.GetZones()
                             on emp.Zoneid equals z.id
                            join r in _emp.GetRegions() on emp.Regionid equals r.ID
                            join b in _emp.GetBranch() on emp.Branchid equals b.ID

                            orderby emp.id
                            select new
                            {
                                emp.EmpId,
                                emp.Emp_name,
                                emp.Emp_Address,
                                emp.Mobil_No,
                                emp.Email_Id,
                                emp.Gender,
                                emp.Date_of_Birth,
                                d.DesignationName,
                                r.Regionname,
                                z.Zonename,
                                b.BranchName

                            }).ToList();

            ViewBag.Datalist = listdata;


            return View();


        }

        public IActionResult ExportData()
        {
            try
            {



                var listdata = (from emp in _emp.GetEmps()
                                join d in _emp.GetDesignations() on emp.DesignationId equals d.ID
                                join z in _emp.GetZones()
                                 on emp.Zoneid equals z.id
                                join r in _emp.GetRegions() on emp.Regionid equals r.ID
                                join b in _emp.GetBranch() on emp.Branchid equals b.ID
                                join dd in _emp.Doclist() on emp.EmpId equals dd.EmpId
                                join tt in _emp.techlist() on emp.EmpId equals tt.EmpID
                                join th in _emp.Technologies() on tt.TechId equals th.Id

                                orderby emp.id
                                select new
                                {
                                    emp.EmpId,
                                    emp.Emp_name,
                                    emp.Emp_Address,
                                    emp.Mobil_No,
                                    emp.Email_Id,
                                    emp.Gender,
                                    emp.Date_of_Birth,
                                    d.DesignationName,
                                    r.Regionname,
                                    z.Zonename,
                                    b.BranchName,
                                    dd.DocumentName,
                                    th.TechnologyName

                                }).ToList();

                MemoryStream stream;
                string fileName = "ReportFile.xlsx";
                using (XLWorkbook wb = new XLWorkbook())
                {

                    wb.Worksheets.Add(ToDataTable(listdata), fileName);
                    using (stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);

                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                    }


                }




            }
            catch (Exception)
            {

                throw;
            }




        }



        public IActionResult Paritalmod(int customerId)
        {

            try
            {



                List<EmployeeDocument> listdata = new List<EmployeeDocument>();

                var fil = Path.Combine(_hostingEnvironment.ContentRootPath, "File");
                foreach (var item in (_emp.Doclist().Where(x => x.EmpId == customerId).ToList()))
                {

                    listdata.Add(new EmployeeDocument() { DocumentName = item.DocumentName, id = item.id });

                }

                ViewBag.Doclist = listdata;
            }
            catch (Exception)
            {

                throw;
            }

            return PartialView("ViewDoc");

        }

        public IActionResult DownloadFile(int id)
        {

            try
            {

         
                EmployeeDocument document = _emp.Doclist().Where(x => x.id == id).FirstOrDefault(); 


                if (document == null)
                {
                    
                    return NotFound();
                }

                
                string serverPath = Path.Combine(_hostingEnvironment.ContentRootPath, document.DocPath); 

                return PhysicalFile(serverPath, "application/octet-stream", document.DocumentName);

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public System.Data.DataTable ToDataTable<T>(List<T> items)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

    }
}
