using DesignPatterns.AdapterDP.Models;
using System;

namespace DesignPatterns.AdapterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeeArray = new string[5, 5]
            {
                { "101", "Ahmet", "Şahin", "Yazılım", "10000" },
                { "102", "Mehmet", "Şahin", "Sistem", "20000" },
                { "103", "Gökhan", "Sarı", "Ofis", "30000" },
                { "104", "Ali", "Veli", "Grafik", "40000" },
                { "105", "Hasan", "Keskin", "Mobil", "50000" }

            };
            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR System passes employee string array to adapter system\n");
            target.ProcessCompanySallary(employeeArray);
        }
    }
}
