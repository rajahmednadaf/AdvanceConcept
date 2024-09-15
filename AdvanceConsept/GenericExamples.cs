using AdvanceConsept.Generics;

namespace AdvanceConsept
{
    public class GenericExamples
    {
        public GenericExamples() 
        {
            /*Simple example of Generics*/
            Console.WriteLine("Generic Class");

            var boxObj = new Box<int>();
            boxObj.SetContent(7);
            Console.WriteLine(boxObj.GetContent());

            var stringBox = new Box<string>();
            stringBox.SetContent("Hello");
            Console.WriteLine(stringBox.GetContent());

            /* Return the defult value for types */
            Console.WriteLine("Generics Method");
            var method = new GenericMethod();
            int defaultInt = method.GetDefault<int>(); // Returns 0
            Console.WriteLine(defaultInt);
            string defaultString = method.GetDefault<string>(); // Returns null
            Console.WriteLine(defaultString);


            Console.WriteLine("Generics Interface");
            var genericInterface = new GenericInterface<int>();

            genericInterface.SetValue(1);
            genericInterface.SetValue(2);
            genericInterface.SetValue(3);
            genericInterface.SetValue(4);
            genericInterface.SetValue(5);

            var mylist = genericInterface.GetValue();

            mylist.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Generic With Constaints");

            var genericWithConstraintsObj = new GenericWithConstrainsClass();

            var obj = genericWithConstraintsObj.CreateInstance<TestClass>();

            Console.WriteLine(obj.A);


            Console.WriteLine("Generic class With Constaints");
            // Usage
            var user = new GenericClassWithConstrainst<User>();
            user.Add(new User { Id = 1, Name = "John" });
            User userobj = user.GetById(1);

            Console.WriteLine(userobj.Id);
            Console.WriteLine(userobj.Name);

            //I get error while trying to create the object of type UserDefined as it is not implemented the IIdentifiable interface
            //var userRepo = new GenericClassWithConstrainst<UserDefined>();


            Console.WriteLine("Generic Methods with Multiple Type Parameters");


            var pair = new Pair<int, string>(1, "One");
            var processor = new PairProcessor();
            processor.PrintPair(pair);
        }
    }
}
