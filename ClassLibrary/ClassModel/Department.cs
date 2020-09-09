using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        /// <summary>
        /// Department Class
        /// Department Id
        /// Department Name
        /// </summary>
        public int DepartmentId { get; set; }

        //Employee Department Name
        [Required]
        public string Department_Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
