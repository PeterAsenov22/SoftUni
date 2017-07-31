namespace Strategy_Pattern
{

    public class AnotherPersonComparator:IComparePerson
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
