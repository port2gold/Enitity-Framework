using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ClassModel
{
    public class Helper
    {
        public Helper(string firstName, string lastName, string deptName)
        {
            FirstName = firstName;
            LastName = lastName;
            DeptpartmentName = deptName;
        }
        public  string FirstName { get; set; }
        public string LastName { get; set; }

        public string DeptpartmentName { get; set; }
    }
}
