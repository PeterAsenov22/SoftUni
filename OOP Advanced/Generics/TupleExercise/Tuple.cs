namespace TupleExercise
{
    public class Tuple<T,T1>
    {
        private T firstItem;
        private T1 secondItem;
        
        public Tuple(T first, T1 second)
        {
            this.firstItem = first;
            this.secondItem = second;
        }

        public override string ToString()
        {
            return $"{firstItem} -> {secondItem}";
        }
    }
}
