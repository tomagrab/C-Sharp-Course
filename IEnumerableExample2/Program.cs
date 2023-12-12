namespace IEnumerableDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionSum(new int[] { 1, 2, 3, 4, 5 });
            CollectionSum(new Queue<int>(new int[] { 6, 7, 8, 9, 10 }));
            CollectionSum(new Stack<int>(new int[] { 11, 12, 13, 14, 15 }));
            CollectionSum(new List<int>(new int[] { 16, 17, 18, 19, 20 }));
            CollectionSum(new LinkedList<int>(new int[] { 21, 22, 23, 24, 25 }));
            CollectionSum(new HashSet<int>(new int[] { 26, 27, 28, 29, 30 }));
            CollectionSum(new SortedSet<int>(new int[] { 31, 32, 33, 34, 35 }));
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            /* 
                * Sum variable to store the sum of the numbers in anyCollection
             */
            int sum = 0;
            /* 
                * For each number in the collection passed to this method
             */
            foreach (int num in anyCollection)
            {
                sum += num;
            }
            /* 
                * Print the sum of the numbers in the collection
             */
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}