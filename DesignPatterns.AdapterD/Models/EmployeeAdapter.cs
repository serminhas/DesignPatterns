using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterDP.Models
{

    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine($"Rs. {employee.Salary} Salary Credit to {employee.FirstName} {employee.LastName} Account");
            //}
            employees.ForEach(employee => Console.WriteLine($"Rs. {employee.Salary.ToString().PadRight(5)} Salary Credit to {employee.FirstName.PadRight(7)} {employee.LastName.PadRight(7)} Account"));
        }
    }
    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        public void ProcessCompanySallary(string[,] employeeArray)
        {
            string Id = null;
            string FirstName = null;
            string LastName = null;
            string Salary = null;
            string Designation = null;

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < employeeArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeeArray.GetLength(1); j++)
                {
                    switch(j)
                    {
                        case 0: 
                            {
                                Id = employeeArray[i, j];
                                break;
                            }
                        case 1: 
                            {
                                FirstName = employeeArray[i, j];
                                break; 
                            }
                        case 2:
                            {
                                LastName = employeeArray[i, j];
                                break;
                            }
                        case 3:
                            {
                                Designation = employeeArray[i, j];
                                break;
                            }
                        default:
                            {
                                Salary = employeeArray[i, j];
                                break;
                            }
                    }

                }
                employees.Add(new Employee(Convert.ToInt32(Id), FirstName, LastName, Convert.ToDecimal(Salary), Designation));
               

            }
            Console.WriteLine("Adapter Converted Array of Employee to List of Employee");
            Console.Write("Then delegate to the ThirdPartyBillingSystem for processing the employee Salary\n");
            ProcessSalary(employees);
        }
    }
}
