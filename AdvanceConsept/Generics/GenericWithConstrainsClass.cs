namespace AdvanceConsept.Generics
{
    //Retuen the object of the class specifies
    public class GenericWithConstrainsClass
    {

        public T CreateInstance<T>() where T : new()
        {
            return new T();
        }

    }

    public class TestClass
    {
        public int A = 10;

    }
}
