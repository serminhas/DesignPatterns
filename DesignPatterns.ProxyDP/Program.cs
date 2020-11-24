using System;

namespace DesignPatterns.ProxyDP
{
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with role developer to folderproxy");
            Employee developer = new Employee("harun", "123", "Developer");
            SharedFolderProxy proxy1 = new SharedFolderProxy(developer);
            proxy1.PerformRWOperation();

            Console.WriteLine();

            Console.WriteLine("Client passing employee with role manager to folderproxy");
            Employee manager = new Employee("harun", "123", "Manager");
            SharedFolderProxy proxy2 = new SharedFolderProxy(manager);
            proxy2.PerformRWOperation();
        }
    }
}
