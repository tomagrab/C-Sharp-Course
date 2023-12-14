namespace AbstractClasses.Models.Shapes
{
    class Cube : Shape
    {
        public double Length { get; set; }
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a length of {Length} and a volume of {Volume():N2}");
        }
    }
}