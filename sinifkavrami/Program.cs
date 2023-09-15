using System;

namespace sinifkavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Employee employeeOne = new Employee();
        employeeOne.Name = "Asli";
        employeeOne.LastName = "Sen";
        employeeOne.No = 45678;
        employeeOne.Department = "HR";

        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("*******************");

        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Ayse";
        employeeTwo.LastName = "Kara";
        employeeTwo.No = 4567890;
        employeeTwo.Department = "IT";

        employeeTwo.GetEmployeeInfo();
        }
    }


     class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
    }
}