namespace AdvanceConsept.Generics
{
    /*
     * Explanation: The Repository<T> class is constrained to types that implement IIdentifiable and have a parameterless constructor.
     * This makes sure the repository can work with types that have an Id property.
     */
    public class GenericClassWithConstrainst<T> where T : class, IIdentifiable, new()
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }
    }

    public interface IIdentifiable
    {
        int Id { get; }
    }

    public class User : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserDefined 
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
