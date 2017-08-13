namespace Logger.Models.Layouts
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(Enum reportLevel, params string[] info)
        {
            string dateTime = info[0];
            string message = info[1];
            return string.Format($"{dateTime} - {reportLevel} - {message}");
        }
    }
}
