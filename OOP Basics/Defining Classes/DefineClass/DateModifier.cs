using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class DateModifier
    {
        private int differenceBetweenDates;

        public int Difference
        {
            get { return this.differenceBetweenDates; }
            set { this.differenceBetweenDates = value; }
        }

        public void CalculateDifference(string firstDate, string secondDate)
        {
            var firstDateParams = firstDate.Split();
            var firstDateDay = int.Parse(firstDateParams[2]);
            var firstDateMonth = int.Parse(firstDateParams[1]);
            var firstDateYear = int.Parse(firstDateParams[0]);

            var secondDateParams = secondDate.Split();
            var secondDateDay = int.Parse(secondDateParams[2]);
            var secondDateMonth = int.Parse(secondDateParams[1]);
            var secondDateYear = int.Parse(secondDateParams[0]);

            var firstDateTime = new DateTime(firstDateYear,firstDateMonth,firstDateDay);
            var secondDateTime = new DateTime(secondDateYear,secondDateMonth,secondDateDay);

            var difference = firstDateTime - secondDateTime;
            this.Difference = Math.Abs(difference.Days);
        }
    }
}
