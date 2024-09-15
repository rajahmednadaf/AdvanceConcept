namespace AdvanceConsept.Generics
{
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    public class PairProcessor
    {
        public void PrintPair<T1, T2>(Pair<T1, T2> pair)
        {
            Console.WriteLine($"First: {pair.First}, Second: {pair.Second}");
        }
    }
}
