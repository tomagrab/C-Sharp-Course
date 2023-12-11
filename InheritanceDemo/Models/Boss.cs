namespace InheritanceDemo.Employees
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }
        public Boss()
        {
            CompanyCar = "BMW";
        }
        public Boss(string firstName, string lastName, int salary, string companyCar) : base(firstName, lastName, salary)

        {
            CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm da bauss!");
        }

        public override void Work()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm working like a boss!");
        }

        public override void Pause()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} and I'm taking a break from my work as a boss!");
        }
    }
}