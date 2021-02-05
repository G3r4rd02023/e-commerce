using ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.Helpers
{
    public class CombosHelper:IDisposable
    {

        private static EcommerceContext db = new EcommerceContext();

        public static List<Department>GetDepartments()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Select a department...]",
            });         

            return departments.OrderBy(d => d.Name).ToList();

        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}