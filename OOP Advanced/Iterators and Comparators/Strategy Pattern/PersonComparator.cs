namespace Strategy_Pattern
{
    public class PersonComparator:IComparePerson
    {
        public int Compare(Person x, Person y)
        {
            var nameLengthCompare = x.Name.Length.CompareTo(y.Name.Length);
            if (nameLengthCompare != 0)
            {
                return nameLengthCompare;
            }

            return x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
        }
    }
}
