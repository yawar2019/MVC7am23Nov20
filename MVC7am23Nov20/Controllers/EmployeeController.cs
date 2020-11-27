using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC7am23Nov20.Models;

namespace MVC7am23Nov20.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public int Add()
        {
            int a = 10, b = 20;
            return a + b;
        }

        [NonAction]
        public int Sub()
        {
            int a = 20, b = 10;
            return a - b;
        }

        public string GetEmpId(int? eid)
        {
            return "EmpId:"+eid;
        }

        public string  GeEmployeeDetail(int id,string EmpName,string Designation) {

            return "My EmpId id:"+id+" and EmpName: "+EmpName+" And Designation "+Designation;
        }

        public string GeEmployeeDetail2(int id)
        {

            return "My EmpId id:" + id + " and EmpName: " +Request.QueryString["EmpName"] + " And Designation " +Request.QueryString["Designation"];
        }

        public string GeEmployeeDetail3()
        {

            return "EmpName: " + Request.QueryString["EmpName"] + " And Designation " + Request.QueryString["Designation"];
        }

        public ActionResult SendValue() {
            EmployeeModel obj = new EmployeeModel();
          
            obj.EmpId = 1211;
            obj.EmpName = "Vidhi";
            obj.EmpSalary = 210000;

            ViewBag.Empdetail =obj;

            return View();
        }

        public ActionResult SendMultipleValue()
        {
            List<EmployeeModel> listObj = new List<Models.EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();

            obj.EmpId = 1211;
            obj.EmpName = "Vidhi";
            obj.EmpSalary = 210000;


            EmployeeModel obj1 = new EmployeeModel();

            obj1.EmpId = 1212;
            obj1.EmpName = "Sreedevi";
            obj1.EmpSalary = 310000;


            EmployeeModel obj2 = new EmployeeModel();

            obj2.EmpId = 1213;
            obj2.EmpName = "Sneha";
            obj2.EmpSalary = 410000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            ViewBag.Empdetail = listObj;

            return View();
        }

        public ActionResult SendValueExample2()
        {
            EmployeeModel obj = new EmployeeModel();

            obj.EmpId = 1211;
            obj.EmpName = "Vidhi";
            obj.EmpSalary = 210000;


            //EmployeeModel model=obj;
            return View(obj);
        }


        public ActionResult SendMultipleValueExample2()
        {
            List<EmployeeModel> listObj = new List<Models.EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();

            obj.EmpId = 1211;
            obj.EmpName = "Vidhi";
            obj.EmpSalary = 210000;


            EmployeeModel obj1 = new EmployeeModel();

            obj1.EmpId = 1212;
            obj1.EmpName = "Sreedevi";
            obj1.EmpSalary = 310000;


            EmployeeModel obj2 = new EmployeeModel();

            obj2.EmpId = 1213;
            obj2.EmpName = "Sneha";
            obj2.EmpSalary = 410000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


          

            return View(listObj);
        }
        public ActionResult SendEmpDeptinfo()
        {
            List<EmployeeModel> listObj = new List<Models.EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();

            obj.EmpId = 1211;
            obj.EmpName = "Vidhi";
            obj.EmpSalary = 210000;


            EmployeeModel obj1 = new EmployeeModel();

            obj1.EmpId = 1212;
            obj1.EmpName = "Sreedevi";
            obj1.EmpSalary = 310000;


            EmployeeModel obj2 = new EmployeeModel();

            obj2.EmpId = 1213;
            obj2.EmpName = "Sneha";
            obj2.EmpSalary = 410000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            EmpDept empdept = new Models.EmpDept();
            empdept.Emp =listObj;
            empdept.dept = dept;


            return View(empdept);
        }
    }
}