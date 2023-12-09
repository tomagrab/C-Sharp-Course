namespace HashTables.Models
{
    class Student
    {
        // Property for ID
        public int Id { get; set; }
        // Property for Name
        public string Name { get; set; }
        // Property for GPA
        public float GPA { get; set; }
        // Constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}