namespace InheritanceDemo.Models
{
    class Radio : Electronic
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }
        public void ListenRadio()
        {
            if (IsOn)
                Console.WriteLine("Listening to the radio");
            else
                Console.WriteLine("Radio is off");
        }
    }
}