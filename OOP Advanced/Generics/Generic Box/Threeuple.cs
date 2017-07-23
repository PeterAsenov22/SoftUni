namespace Generic_Box
{
    public class Threeuple<T,T1,T2>
    {
        private T firstItem;
        private T1 secondItem;
        private T2 thirdItem;

        public Threeuple(T first, T1 second, T2 third)
        {
            this.firstItem = first;
            this.secondItem = second;
            this.thirdItem = third;
        }

        public override string ToString()
        {
            return $"{firstItem} -> {secondItem} -> {thirdItem}";
        }
    }
}
