using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ClassModel
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Methods that class implementing the interface must implement
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="ln"></param>
        /// <param name="email"></param>
        /// <param name="pn"></param>
        /// <param name="hd"></param>
        /// <param name="salary"></param>
        /// <param name="deptId"></param>
        public void AddEmployee(string fn, string ln, string email, string pn, DateTime hd, decimal salary, int deptId);

        public void AddDepartment(string dept);
        public void UpdateEmployee(int id, string fn, string ln, string email, string pn, DateTime hd, decimal salary, int deptId);
        public void UpdateDept(int id, string dept);
        public void DeleteEmployee(int id);
        public void DeleteDepartment(int id);

        public List<Helper> EmployeeByDeptName();

        public List<Helper> RecordGroupedByDepartment();
        public List<Helper> EmployeeSalaryAbove();
        public void EmployeeDepartmentAssignedOrNotAssigned();

        public List<Helper> DeptNotAssignedEmployee();

        public List<Department> GetAllDept();
        public List<Employee> GetAllEmployee();
        public int GetDeptId(string dept);

        public int GetEmpId(string firstname, string lastname);













    }
}
