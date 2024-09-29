using AdvanceConsept.AOP;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdvanceConsept
{
    public class AttributeClass
    {
        public static void SerializingAttributeExample()
        {
            Employee emp = new Employee
            {
                Id = 101,
                Name = "John Doe",
                Salary = 50000.00m
            };

            // Serialize the Employee object to a file
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            using (FileStream stream = new FileStream("employee.dat", FileMode.Create))
            {
                formatter.Serialize(stream, emp);
                Console.WriteLine("Employee object serialized to employee.dat file.");
            }

            // Deserialize the Employee object from the file
            using (FileStream stream = new FileStream("employee.dat", FileMode.Open))
            {
                Employee deserializedEmp = (Employee)formatter.Deserialize(stream);
                Console.WriteLine("Employee object deserialized from employee.dat file:");
                deserializedEmp.Display();
            }
        }
    }
}
