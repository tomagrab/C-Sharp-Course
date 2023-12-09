namespace InheritanceDemo.Models
{
    class Electronic
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public Electronic(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
        public void Toggle()
        {
            if (IsOn)
                SwitchOff();
            else
                SwitchOn();
        }
    }
}