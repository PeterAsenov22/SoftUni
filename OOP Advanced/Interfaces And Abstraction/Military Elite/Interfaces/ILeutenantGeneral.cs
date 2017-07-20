namespace Military_Elite
{
    using System.Collections.Generic;
    using Military_Elite.Soldiers;

    public interface ILeutenantGeneral
    {
        List<Private> Privates { get; }
    }
}
