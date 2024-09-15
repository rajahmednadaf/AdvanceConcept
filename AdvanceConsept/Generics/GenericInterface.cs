namespace AdvanceConsept.Generics
{
    public interface IGenericInterface<T>
    {
        public void SetValue(T value);
        public List<T> GetValue();
    }

    public class GenericInterface<T> : IGenericInterface<T>
    {
        private List<T> _myList = new List<T>();
        public void SetValue(T value)
        {
            _myList.Add(value);
        }

        public List<T> GetValue()
        {
            return _myList;
        }
    }

}
