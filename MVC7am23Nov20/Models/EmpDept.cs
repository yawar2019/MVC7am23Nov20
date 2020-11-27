using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC7am23Nov20.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> Emp{get;set;}
        public DepartmentModel dept{get;set;}
    }
}