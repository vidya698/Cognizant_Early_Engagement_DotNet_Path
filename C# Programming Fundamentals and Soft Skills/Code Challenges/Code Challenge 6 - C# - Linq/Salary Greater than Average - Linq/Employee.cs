/******** FOR REFERENCE ONLY. DO NOT CHANGE ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary		//DO NOT CHANGE the namespace name
{
	public class Employee
	{
		public String EmpId { get; set; }
		public String EmpName { get; set; }
		public String Designation { get; set; }
		public int Salary { get; set; }
		
		public Employee(String eId, String eName, String desg, int sal)
		{
			this.EmpId = eId;
			this.EmpName = eName;
			this.Designation = desg;
			this.Salary = sal;
		}
	}
}
