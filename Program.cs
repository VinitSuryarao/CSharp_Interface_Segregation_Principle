using System;

namespace Interface_Segregation_Principle
{
    // I  : Interface Segregation Principle (ISP)
    //Instead of making one interface with many methods, divide into smaller interface with less methods.

    //// Before Apply ISP
    //interface IBusiness
    //{
    //    void Employee(string EmpName);
    //    decimal Salary(decimal salary);
    //    void AnnualSales(string data);
    //}

    // After Apply ISP :- Make seperate Interface for multiple methods
    interface IEmployee
    {
        void Employee(string EmpName);
    }
    interface ISalary
    {
        decimal Salary(decimal salary);
    }
    interface AnnualSales
    {
        void AnnualSales(string data);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
