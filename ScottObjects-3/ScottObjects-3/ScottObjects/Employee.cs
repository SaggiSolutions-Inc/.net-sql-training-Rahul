using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects
{
    public class Employee : Person
    {
        public  int Id { get; set; }
        public string Job { get;  set; }
        public int? ManagerId { get;  set; }
        public DateTime HireDate { get;  set; }
        public int Salary { get;  set; }
        public int? Commission { get;  set; }
        public int DeptNo { get;  set; }

        public Employee(int id, string firstName, string middleInitial, string lastName, string email, string phone,
            string job, int? managerId, DateTime hireDate, int salary, int? commission, int deptNo)
            : base(id,firstName, middleInitial, lastName, email, phone)
        {
            Id = id;
            Job = job;
            ManagerId = managerId;
            HireDate = hireDate;
            Salary = salary;
            Commission = commission;
            DeptNo = deptNo;
        }

        
    }

}
