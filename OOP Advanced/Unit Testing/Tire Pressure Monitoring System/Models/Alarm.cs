namespace Tire_Pressure_Monitoring_System
{
    public class Alarm : IAlarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        private readonly ISensor sensor;

        public Alarm(ISensor sensor)
        {
            this.sensor = sensor;
        }

        bool alarmOn = false;

        public void Check()
        {
            double psiPressureValue = sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                alarmOn = true;
            }
        }

        public bool AlarmOn
        {
            get { return alarmOn; }
        }
    }
}
