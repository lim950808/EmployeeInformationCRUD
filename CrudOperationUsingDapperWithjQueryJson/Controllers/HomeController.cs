using CrudOperationUsingDapperWithjQueryJson.Models;
using CrudOperationUsingDapperWithjQueryJson.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperationUsingDapperWithjQueryJson.Controllers
{
    public class HomeController : Controller
    {
        //Get Employee List with json data    
        public JsonResult GetEmpDetails()
        {
            EmpRepository EmpRepo = new EmpRepository();
            return Json(EmpRepo.GetAllEmployees(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddEmployee()
        {

            return View();
        }
        //Get record by Empid for edit    
        public ActionResult Edit(int? id)
        {
            EmpRepository EmpRepo = new EmpRepository();
            return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.Id == id));
        }
        //Add Employee details with json data    
        [HttpPost]
        public JsonResult AddEmployee(EmpModel EmpDet)

        {
            try
            {
                EmpRepository EmpRepo = new EmpRepository();
                EmpRepo.AddEmployee(EmpDet);
                return Json("Records added Successfully.");
            }
            catch
            {
                return Json("Records not added,");
            }
        }

        //Delete the records by id    
        [HttpPost]
        public JsonResult Delete(int id)
        {
            EmpRepository EmpRepo = new EmpRepository();
            EmpRepo.DeleteEmployee(id);
            return Json("Records deleted successfully.", JsonRequestBehavior.AllowGet);
        }
        //Updated edited records    
        [HttpPost]
        public JsonResult Edit(EmpModel EmpUpdateDet)
        {
            EmpRepository EmpRepo = new EmpRepository();
            EmpRepo.UpdateEmployee(EmpUpdateDet);
            return Json("Records updated successfully.", JsonRequestBehavior.AllowGet);
        }
        //Get employee list of Partial view     
        [HttpGet]
        public PartialViewResult EmployeeDetails()
        {
            return PartialView("_EmployeeDetails");
        }
    }
}