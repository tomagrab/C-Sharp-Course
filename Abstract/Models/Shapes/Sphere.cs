namespace AbstractClasses.Models.Shapes
{
    class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a radius of {Radius} and a volume of {Volume():N2}");
        }
    }
}