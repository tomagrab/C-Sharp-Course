namespace InheritanceDemo.Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public Employee()
        {
            FirstName = "John";
            LastName = "Doe";
            Salary = 1000;
        }
        public virtual void Work()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm working!");
        }
        public virtual void Pause()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm taking a break!");
        }

        public override string ToString()
        {
            return $"\nEmployee: {FirstName} {LastName} | Salary: {Salary}\n";
        }
    }
}