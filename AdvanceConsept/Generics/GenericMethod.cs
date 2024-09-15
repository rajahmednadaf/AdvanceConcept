namespace AdvanceConsept.Generics
{
    public class GenericMethod
    {
        public T GetDefault<T>()
        {
            return default(T);
        }
    }
}
