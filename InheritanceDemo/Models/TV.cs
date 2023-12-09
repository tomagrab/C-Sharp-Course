namespace InheritanceDemo.Models
{
    class TV : Electronic
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        public void WatchTV()
        {
            if (IsOn)
                Console.WriteLine("Listening to the TV");
            else
                Console.WriteLine("TV is off");
        }
    }
}