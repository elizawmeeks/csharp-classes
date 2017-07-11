using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can do it!");

            Company elizacom = new Company("ELIZAWORLD");

            Employee Eliza = new Employee("Eliza", "CEO", "today");
            Employee Chaz = new Employee("Chaz", "Pro Helper", "this very instant");
            Employee Adam = new Employee("Adam", "Cool dude", "also today");

            elizacom.addEmployee(Eliza);
            elizacom.addEmployee(Chaz);
            elizacom.addEmployee(Adam);

            elizacom.listEmployees();
            
        }
    }

    // Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
    // Consider the concept of aggregation, and modify the Company class so that you assign employees to a company.
    // In the Main method, create a company, and three employees, and then assign the employees to the company.
    // Update the Company class to write the name of each employee to the console. Consider a method named ListEmployees().

    public class Employee
    {
        public string Name;
        public string JobTitle;
        public string StartDate;

        public Employee (string name, string job, string date){
            this.Name = name;
            this.JobTitle = job;
            this.StartDate = date;
        }
    }

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public static List<Employee> CurrentEmployees = new List<Employee>();
       

        // Create a method that allows external code to add an employee
        public void addEmployee (Employee name){
            CurrentEmployees.Add(name);
        }

        // Create a method that allows external code to remove an employee
        public void removeEmployee (Employee name){
            CurrentEmployees.Remove(name);
        }

        public void listEmployees(){
            foreach( Employee thing in CurrentEmployees){
                Console.WriteLine($"{thing.Name} {thing.JobTitle} {thing.StartDate}");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string companyName){
            string Name = companyName;
            DateTime CreatedOn = DateTime.Today;
        }
    }
}