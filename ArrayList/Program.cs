using System.Collections;

namespace ArrayListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decalre the ArrayList
            ArrayList list = new ArrayList();

            list.Add("Hello");
            list.Add("World");
            list.Add("!");
            list.Add(123);
            list.Add(456);
            list.Add(789);
            list.Add(true);
            list.Add(false);

            Console.WriteLine("Count: {0}", list.Count);

            double sum = 0;

            foreach (object obj in list)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is bool)
                {
                    Console.WriteLine("Boolean: {0}", obj);
                }
                else if (obj is string)
                {
                    Console.WriteLine("String: {0}", obj);
                }
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}