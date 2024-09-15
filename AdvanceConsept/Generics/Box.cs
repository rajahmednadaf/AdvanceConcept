namespace AdvanceConsept.Generics
{
    public class Box<T>
    {
        private T _content;

        public T GetContent()
        {
            return _content;
        }

        public void SetContent(T content) 
        {
            _content = content;
        }
    }
}
