namespace Telephony
{
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Smartphone:ICallable,IBrowseable
    {
        private List<string> NumbersToCall { get; set; }

        private List<string> SitesToVisit { get; set; }

        public Smartphone(List<string> numbersToCall, List<string> sitesToVisit)
        {
            this.NumbersToCall = numbersToCall;
            this.SitesToVisit = sitesToVisit;
        }

        public string Call()
        {
            var sb = new StringBuilder();
            var regex = new Regex(@"^\d+$");

            foreach (var number in this.NumbersToCall)
            {
                sb.AppendLine(regex.IsMatch(number) ? $"Calling... {number}" : "Invalid number!");
            }

            return sb.ToString().Trim();
        }

        public string Browse()
        {
            var sb = new StringBuilder();
            var regex = new Regex(@"^[^\d]*$");

            foreach (var site in this.SitesToVisit)
            {
                sb.AppendLine(regex.IsMatch(site) ? $"Browsing: {site}!" : "Invalid URL!");
            }

            return sb.ToString().Trim();
        }
    }
}
