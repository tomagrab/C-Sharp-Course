namespace IEnumerableAndIEnumeratorDemo.Models
{
    class Dog : Animal
    {
        public string Breed { get; set; }
        public bool IsGoodBoi { get; set; }
        public Dog()
        {
            Breed = "Unknown";
            IsGoodBoi = false;
        }
        public Dog(string name, string type, string color, string breed, bool isGoodBoi) : base(name, type, color)
        {
            Breed = breed;
            IsGoodBoi = isGoodBoi;
        }
        public override string MakeSound()
        {
            return $"{Name} barks!";
        }
        public string GiveTreat(int numberOfTreats)
        {
            if (IsGoodBoi)
            {
                return $"{Name} is a good boi and gets {numberOfTreats} treats";
            }
            else
            {
                return $"{Name} is not a good boi and missed out on getting {numberOfTreats} treats";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}Breed: {Breed}\nIsGoodBoi: {IsGoodBoi}\n";
        }
    }
}