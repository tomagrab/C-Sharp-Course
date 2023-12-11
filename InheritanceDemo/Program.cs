using InheritanceDemo.Employees;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee jakeTheWorker = new Employee("Jake", "The Worker", 2000);
            Boss jakeTheBoss = new Boss("Jake", "The Boss", 5000, "BMW");
            Trainee jakeTheTrainee = new Trainee("Jake", "The Trainee", 1000, 20, 10);

            jakeTheWorker.Work();
            jakeTheWorker.Pause();
            Console.WriteLine(jakeTheWorker.ToString());

            jakeTheBoss.Lead();
            jakeTheBoss.Work();
            jakeTheBoss.Pause();
            Console.WriteLine(jakeTheBoss.ToString());

            jakeTheTrainee.Learn();
            jakeTheTrainee.Work();
            jakeTheTrainee.Pause();
            Console.WriteLine(jakeTheTrainee.ToString());

            Console.ReadKey();
        }
    }
}