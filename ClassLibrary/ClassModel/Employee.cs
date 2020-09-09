using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Employee
    {
        /// <summary>
        /// Employee class
        /// </summary>
        /// 
        //Employee Id which is the Primary key
        public int EmployeeId { get; set; }
        

        //Employee First Name
        [Required]
        public string First_Name { get; set; }

        //Employee Last name
        [Required]
        public string Last_Name { get; set; }

        //Employee Email
        public string Email { get; set; }

        //Employee Phone Number
        public string Phone_Number { get; set; }

        //Employee Hire Date
        public DateTime Hire_Date { get; set; }
        [Required]
        public decimal Salary { get; set; }

        /// <summary>
        /// Foreign Key 
        /// </summary>
        public int? DepartmentId { get; set; }
        public Department Department { get; set; } 


    }
}
