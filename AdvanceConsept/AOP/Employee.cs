namespace AdvanceConsept.AOP
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; } 

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
        }
    }
}
