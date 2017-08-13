namespace Logger.Models.Layouts
{
    using System;
    using System.Text;
    using Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(Enum reportLevel, params string[] info)
        {
            string date = info[0];
            string message = info[1];
            var sb = new StringBuilder();
            sb.AppendLine("<log>");
            sb.AppendLine($"   <date>{date}</date>");
            sb.AppendLine($"   <level>{reportLevel}</level>");
            sb.AppendLine($"   <message>{message}</message>");
            sb.Append("</log>");

            return sb.ToString();
        }
    }
}
