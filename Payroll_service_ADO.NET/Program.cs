using System;

namespace Payroll_service_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepository emprepository = new EmployeeRepository();  //Creating a object of EmployeeRepository class.

            emprepository.DataBaseConnection(); //  UC1 Ensuring the database connection using the sql connection string
           
            Console.ReadLine();
        }
    }
}
