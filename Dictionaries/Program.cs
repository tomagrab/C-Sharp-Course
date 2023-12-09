using System.Collections.Generic;
using DictionariesDemo.Models;

namespace DictionariesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
                new Employee("A cool dude", "John", 25, 10.5f),
                new Employee("A wicked witch", "Mary", 30, 12.5f),
                new Employee("Another cool dude", "Mike", 35, 15.5f),
                new Employee("A fair maiden", "Jane", 40, 20.5f),
                new Employee("Mark", "Mark", 45, 25.5f)
            };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            // Set a key to search for
            string key = "Mark";
            Employee result = null;

            // Get the employee with the key "A cool dude"
            try
            {
                if (employeeDirectory.TryGetValue(key, out result))
                {
                    Console.WriteLine($"Employee found: {result.Name} (Role: {result.Role}) - {result.Age} years old - {result.Salary} yearly salary");
                }
                else
                {
                    Console.WriteLine("Employee not found");
                }
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key not found");
            }
        }
    }
}
