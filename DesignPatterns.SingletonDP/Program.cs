using System;

namespace DesignPatterns.SingletonDP
{
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            DBHelper dBHelper1 = DBHelper.CreateDBHelper("server=LAPTOP-CCD3KERS\\SQLEXPRESS; database=northwind; uid=sa; pwd=123");
            dBHelper1.StatusMessage = "Connection succeed";

            DBHelper dBHelper2 = DBHelper.CreateDBHelper("server=127.0.0.1; database=phonebook; uid=sa; pwd=123");
            dBHelper2.StatusMessage = "Connection succeed!!!";

            Console.WriteLine(dBHelper1.StatusMessage + "\n" + dBHelper2.StatusMessage);
            Console.WriteLine(dBHelper1.ConnectionString + "\n" + dBHelper2.ConnectionString);


        }
    }
}
