using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterDP.Models
{
    public interface ITarget
    {
        void ProcessCompanySallary(string[,] employeeArray);
    }


}
