using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Payroll_service_ADO.NET;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace payrolladotest
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }
        /*UC1:-  /* UC1:- Ability to create a payroll service database and have C# program connect to database.
                - Use the payroll_service database created in MSSQL.
                - Install System.Data.SqlClient Package.
                - Check if the database connection to payroll_service mssql DB is established.
        */
        [Test]
        public void CheckConnection() //Create CheckConnection method to Check Connection
        {
            EmployeeRepository employeeRepository = new EmployeeRepository(); //create object EmployeeRepository class
            bool actual = employeeRepository.DataBaseConnection(); //call method
            bool expected = true; //expected true 
            Assert.AreEqual(expected, actual); // Check equal or not
        }
    }
}
