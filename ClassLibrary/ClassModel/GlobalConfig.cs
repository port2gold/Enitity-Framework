using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ClassModel
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Global configuration class to create an instance of the IRepository
        /// </summary>
        public static IEmployeeRepository IInstance {get; set; }

        /// <summary>
        /// Method that add an instance of Employeee Repository
        /// </summary>
        public static void AddIInstance()
        {
            EmployeeRepository executable = new EmployeeRepository();
            IInstance = executable;
        }
    }
}
