using ClassLibrary.ClassModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        private readonly IEmployeeRepository employer;
        /// <summary>
        /// Form Constructor with the interface passed into it.
        /// </summary>
        /// <param name="emp"></param>
        public Form1(IEmployeeRepository emp)
        {
            InitializeComponent();
            employer = emp;
        }
        /// <summary>
        /// Add product to the database on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string email = textBox3.Text;
                string phoneNumber = textBox4.Text;
                decimal salary = decimal.Parse(textBox5.Text);
                string dept = textBox7.Text;
                DateTime hiredate = dateTimePicker1.Value;
                int deptid = employer.GetDeptId(dept);

                employer.AddEmployee(firstName, lastName, email, phoneNumber, hiredate, salary, deptid);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                var temp = employer.GetAllEmployee();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.First_Name}, {item.Last_Name}");
                }
                listBoxProduct.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incomplete Information Provided");
            }
            
        }
        /// <summary>
        /// Add department to the database on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDept_Click(object sender, EventArgs e)
        {
            try
            {
                string deptName = textBox6.Text;

                employer.AddDepartment(deptName);
                textBox6.Text = "";
                var temp = employer.GetAllDept();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.Department_Name}");
                }
                listBox1.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Encountered");
            }

        }
        /// <summary>
        /// Update the database with the new information provided on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateDept_Click(object sender, EventArgs e)
        {
            try
            {
                int deptId = int.Parse(textBox9.Text);
                string deptName = textBox6.Text;
                employer.UpdateDept(deptId, deptName);
                textBox9.Text = "";
                textBox6.Text = "";
                var temp = employer.GetAllDept();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.Department_Name}");
                }
                listBox1.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incomplete Information Provided");
            }
        }
        /// <summary>
        /// Get Department Id by Department Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                textBox8.Text = "";
                string dept = textBox6.Text;
                int temp = employer.GetDeptId(dept);
                textBox8.Text = temp.ToString();
                textBox6.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Encountered!! Please Try Again");
            }
        }


        /// <summary>
        /// Get Employee Id by the Employee First Name and Employee Last Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = textBox1.Text;
                string lastname = textBox2.Text;
                textBox10.Text = employer.GetEmpId(firstname, lastname).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Employee First Name and Employee Last Name");
            }
            

        }
        /// <summary>
        /// Updates the database with the information of the provided
        /// Uses the Id to get the Employee to Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string email = textBox3.Text;
                string phoneNumber = textBox4.Text;
                decimal salary = decimal.Parse(textBox5.Text);
                string dept = textBox7.Text;
                DateTime hiredate = dateTimePicker1.Value;
                int Empid = int.Parse(textBox11.Text);
                int deptId = employer.GetDeptId(dept);
                employer.UpdateEmployee(Empid, firstName, lastName, email, phoneNumber, hiredate, salary, deptId);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox11.Text = "";
                var temp = employer.GetAllEmployee();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.First_Name} {item.Last_Name}");
                }
                listBoxProduct.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incomplete Information Provided");
            }
        }

        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox11.Text);
                employer.DeleteEmployee(id);
                textBox11.Text = "";
                var temp = employer.GetAllEmployee();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.First_Name} {item.Last_Name}");
                }
                listBoxProduct.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Encountered");
            }
        }

        private void buttonDeleteDept_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox9.Text);
                employer.DeleteDepartment(id);
                textBox9.Text = "";
                var temp = employer.GetAllDept();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.Department_Name}");
                }
                listBoxProduct.DataSource = temp1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered");
            }
        }
        /// <summary>
        /// Output Employee By Department Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = employer.EmployeeByDeptName();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.FirstName}, {item.LastName} =>{item.DeptpartmentName}");
                }
                listBox2.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured");
            }
        
        }
        /// <summary>
        /// Output the employee with Salary Above 150000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbove_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = employer.EmployeeSalaryAbove();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add($"{item.FirstName}, {item.LastName} \t =>\t #{item.DeptpartmentName}");
                }
                listBox2.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            //var temp = employer.RecordGroupedByDepartment();
            //var temp1 = new List<string>();
            //foreach (var item in temp1)
            //{
            //    temp1.Add($"{}");
            //}
            //listBox2.DataSource = temp1;
        }
        /// <summary>
        /// Output the Employee with Department not Assigned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = employer.DeptNotAssignedEmployee();
                var temp1 = new List<string>();
                foreach (var item in temp)
                {
                    temp1.Add(item.DeptpartmentName);
                }
                listBox2.DataSource = temp1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured");
            }
        }
    }
}
