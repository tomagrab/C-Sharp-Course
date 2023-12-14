namespace Polymorphism.Models
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has A relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

        public Car()
        {
            HP = 100;
            Color = "Black";
        }
        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP} Color: {Color}");
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}