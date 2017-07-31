namespace Strategy_Pattern
{
    using System.Collections.Generic;

    public interface IComparePerson : IComparer<Person>
    {
        int Compare(Person x, Person y);
    }
}
