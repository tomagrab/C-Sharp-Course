namespace InheritanceDemo.Employees
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainee()
        {
            WorkingHours = 20;
            SchoolHours = 10;
        }
        public Trainee(string firstName, string lastName, int salary, int workingHours, int schoolHours) : base(firstName, lastName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }
        public void Learn()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm learning!");
        }

        public override void Work()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm working {WorkingHours} hours!");
        }

        public override void Pause()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm taking a break from my work as a trainee!");
        }
    }
}