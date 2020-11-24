using System;

namespace DesignPatterns.ProxyDP.Models
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _folder;
        private Employee _employee;

        public SharedFolderProxy(Employee employee)
        {
            this._employee = employee;
        }

        public void PerformRWOperation()
        {
            string role = _employee.Role.ToLower();
         
            string[] Roles =
            {
                "admin",
                "manager",
                "ceo"
            };

            switch(System.Array.Exists(Roles, x=>x==role))
            {
                case true:
                    {
                        _folder = new SharedFolder();
                        System.Console.WriteLine("Shared Folder Proxy Makes Call to The RealFolder PerformRWOperations Method");
                        _folder.PerformRWOperation();
                        break;

                    }
                default:
                    System.Console.WriteLine("Shared Folder Proxy Says 'You Don't Have Permission to Access This Folder'");
                    break;

            }
        }
    }
}
