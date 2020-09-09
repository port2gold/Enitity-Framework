using ClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibrary.ClassModel
{
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Adds an employeee given the following parameters
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="ln"></param>
        /// <param name="email"></param>
        /// <param name="pn"></param>
        /// <param name="hd"></param>
        /// <param name="salary"></param>
        /// <param name="deptId"></param>
        public void AddEmployee(string fn, string ln, string email, string pn, DateTime hd, decimal salary, int deptId)
        {
            var _empoyee = new Employee
            {
                First_Name = fn,
                Last_Name = ln,
                Email = email,
                Phone_Number = pn,
                Hire_Date = hd,
                Salary = salary,
                DepartmentId = deptId
            };
            using (var context = new EmployeeContext())
            {
                context.Employee.Add(_empoyee);
                context.SaveChanges();
            }
        }


        /// <summary>
        /// Get all the employee
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployee()
        {
            var query = new List<Employee>();
            using (var context = new EmployeeContext())
            {
                query = context.Employee.ToList() ;
            }
            return query;
        }
        public void AddDepartment(string dept)
        {
            var _dept = new Department
            {
                Department_Name = dept
            };
            using (var context = new EmployeeContext())
            {
                context.Department.Add(_dept);
                context.SaveChanges();
            }

        }

        /// <summary>
        /// Gets All the Department
        /// </summary>
        /// <returns></returns>
        public List<Department> GetAllDept()
        {
            var query = new List<Department>();
            using (var context = new EmployeeContext())
            {
                query = context.Department.ToList();
            }
            return query;
        }

        /// <summary>
        /// update the Employee give all the new parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fn"></param>
        /// <param name="ln"></param>
        /// <param name="email"></param>
        /// <param name="pn"></param>
        /// <param name="hd"></param>
        /// <param name="salary"></param>
        /// <param name="deptId"></param>
        public void UpdateEmployee(int id, string fn, string ln, string email, string pn, DateTime hd, decimal salary, int deptId)
        {
            
            using(var context = new EmployeeContext())
            {
                var employee = context.Employee.FirstOrDefault(x => x.EmployeeId == id);

                if(employee != null)
                {
                    employee.First_Name = fn;
                    employee.Last_Name = ln;
                    employee.Email = email;
                    employee.Phone_Number = pn;
                    employee.Hire_Date = hd;
                    employee.Salary = salary;
                    employee.DepartmentId = deptId;

                    context.Employee.Update(employee);
                    context.SaveChanges();

                }

            }
        }

        /// <summary>
        /// Update the department Name with the Id selected.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dept"></param>
        public void UpdateDept(int id, string dept)
        {
            
            using( var context = new EmployeeContext())
            {
                var dp = context.Department.FirstOrDefault(x => x.DepartmentId == id);
                if(dp != null)
                {
                    dp.Department_Name = dept;

                    context.Department.Update(dp);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete the Employee with the the id given
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEmployee(int id)
        {
            using (var context = new EmployeeContext())
            {
                var emp = context.Employee.Single(x => x.EmployeeId == id);

                if(emp != null)
                {
                    context.Employee.Remove(emp);
                    context.SaveChanges();
                }
            }

        }

        /// <summary>
        /// Delete the department with the id given 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteDepartment(int id)
        {
            using (var context = new EmployeeContext())
            {
                var dept = context.Department.Single(x => x.DepartmentId == id);

                if(dept != null)
                {
                    context.Department.Remove(dept);
                    context.SaveChanges();
                }
            }
        }
        public List<Helper> EmployeeByDeptName()
        {
            var temp = new List<Helper>();
            using (var context = new EmployeeContext())
            {

                var query = from emp in context.Employee
                            join dept in context.Department
                            on emp.DepartmentId equals dept.DepartmentId
                            select new Helper(emp.First_Name, emp.Last_Name, dept.Department_Name);
                foreach (var item in query)
                {
                    temp.Add(item);
                }
                            
                            
            }
            return temp;

        }
        
        /// <summary>
        /// Output Employee grouped by Department 
        /// </summary>
        /// <returns></returns>
        public List<Helper> RecordGroupedByDepartment()
        {
            var temp = new List<Helper>();

            using (var context = new EmployeeContext())
            {
                var query = from emp in context.Employee
                            join dept in context.Department
                            on emp.DepartmentId equals dept.DepartmentId
                            group new { emp, dept } by new { emp.Last_Name, emp.First_Name, dept.Department_Name }
                            into grp
                            select new Helper(grp.Key.First_Name, grp.Key.Last_Name, grp.Key.Department_Name);
                            //{
                            //    grp.Key.First_Name,
                            //    grp.Key.Last_Name,
                            //    grp.Key.Department_Name

                            //};

                foreach (var item in query)
                {
                    temp.Add(item);
                }

            }
            return temp;

        }


        /// <summary>
        /// Output Employer with Salary Above 150000
        /// </summary>
        /// <returns></returns>
        public List<Helper> EmployeeSalaryAbove()
        {
            var temp = new List<Helper>();
            using (var context = new EmployeeContext())
            {
                var query = context.Employee.Where(x => x.Salary > 150000)
                                            .Select(z => new Helper(z.First_Name, z.Last_Name, z.Salary.ToString()));
                                            
                foreach (var item in query)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        /// <summary>
        /// Output the Department not Assigned an Employee
        /// </summary>
        /// <returns></returns>
        public List<Helper> DeptNotAssignedEmployee()
        {
            var temp = new List<Helper>();
            using (var context = new EmployeeContext())
            {
                var query = from emp in context.Employee
                            join dept in context.Department
                            on emp.DepartmentId equals dept.DepartmentId
                            where emp.DepartmentId == null
                            select new Helper(emp.First_Name, emp.Last_Name, dept.Department_Name);

                foreach (var item in query)
                {
                    temp.Add(item);
                }
            }
            return temp;

        }

        /// <summary>
        /// Output Department and Employee not Assigned
        /// </summary>
        public void EmployeeDepartmentAssignedOrNotAssigned()
        {
            using (var context = new EmployeeContext())
            {
                //var query = from emp in context.Employee
                //            full outer join dept in context.Department
                //            on emp.DepartmentId equals dept.DepartmentId

            }
        }

        /// <summary>
        /// Get Department by Id
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int GetDeptId(string dept)
        {
            int id =0;
            
            using (var context  = new EmployeeContext())
            {
                var query = context.Department.Where(x => x.Department_Name == dept)
                                               .Select(x => x.DepartmentId)
                                               .Take(1).ToList();
                if(query != null)
                {
                    
                    id = query[0];
                }
                
            }
            return id;
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <returns></returns>

        public int GetEmpId(string firstname, string lastname)
        {
            int id = 0;

            using (var context = new EmployeeContext())
            {
                var query = context.Employee.Where(x => x.First_Name == firstname && x.Last_Name == lastname)
                                               .Select(x => x.EmployeeId)
                                               .Take(1).ToList();
                if (query != null)
                {
                    
                    id = query[0];
                }

            }
            return id;
        }
    }
}
