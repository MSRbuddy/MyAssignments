using System;

namespace EmployeeDetails
{
    internal class Program
    {
        class Emp
        {
            public string name;
            public int id, salary;

            public Emp(string empName,int empId,int empSalary)
            {
                name = empName;
                id = empId;
                salary = empSalary;
            }
        }
        static void Main(string[] args)
        {
            Emp emp1 = new Emp("Akhil", 12345, 30000);
            Emp emp2 = new Emp("Bhanu", 12346, 35000);
            Console.WriteLine("Emp1 name: " + emp1.name + ";" + "Emp1 id: " + emp1.id + ";" + "Emp1 salary: " + emp1.salary);
            Console.WriteLine("Emp2 name: " + emp2.name + ";" + "Emp2 id: " + emp2.id + ";" + "Emp2 salary: " + emp2.salary);

        }
    }
}
