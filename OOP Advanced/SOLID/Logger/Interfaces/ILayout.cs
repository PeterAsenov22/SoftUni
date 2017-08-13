namespace Logger.Interfaces
{
    using System;

    public interface ILayout
    {
        string Format(Enum reportLevel, params string[] info);
    }
}
