using IEnumerableAndIEnumeratorDemo.Models;

namespace IEnumerableAndIEnumeratorDemo
{
    class Program
    {
        /*
            * 1. IEnumerable<T> is a generic interface that is used to iterate through a collection of objects.
            * 2. IEnumerable is the base interface for all non-generic collections that can be enumerated.
         */

        /* 
           * Summary
           * IEnumerable<T> contains a single method that you must implement when implementing this interface;
           * GetEnumerator(), which returns an IEnumerator<T> object.
           * The returned IEnumerator<T> object can be used to iterate through the collection
           * by exposing a Current property that points at the object we are currently at in the collection
         */

        /* 
            * When it is recommended to use the IEnumerable<T> interface?
                * When your collection represents a massive database table and you don't want to copy the entire thing into memory and cause performance issues
            * When it is not recommended to use the IEnumerable<T> interface?
                * You need the results right away and are possibly mutating / editing the objects later on. In this case, it is better to use a List<T> or an Array<T>
         */

        static void Main(string[] args)
        {
            DogShelter dogShelter = new DogShelter("Dog Shelter", new List<Dog>()
            {
                new Dog("Rex", "Dog", "Brown", "German Shepherd", true),
                new Dog("Bella", "Dog", "Black", "Labrador", true),
                new Dog("Max", "Dog", "White", "Labrador", true),
                new Dog("Charlie", "Dog", "Brown", "Poodle", false),
                new Dog("Lucy", "Dog", "White", "Poodle", true),
                new Dog("Bailey", "Dog", "Black", "Poodle", false),
            });

            foreach (Dog dog in dogShelter)
            {
                Console.WriteLine(dog.GiveTreat(2));
            }
        }
    }
}