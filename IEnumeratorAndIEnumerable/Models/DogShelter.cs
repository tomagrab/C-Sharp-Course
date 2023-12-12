using System.Collections;

namespace IEnumerableAndIEnumeratorDemo.Models
{
    class DogShelter : Building, IEnumerable<Dog>
    {
        public List<Dog> dogs;
        public DogShelter(string name, List<Dog> dogs) : base(name)
        {
            this.dogs = dogs;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Number of Dogs: {dogs.Count}";
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }
    }
}