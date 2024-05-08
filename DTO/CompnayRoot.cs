using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   
    public class CompnayRoot{    public Company Company { get; set; }  }
    public class Company {       public List<Employee> Employees { get; set; }  }

    public class Employee
    {
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public string Age { get; set; }
    }

   
}
