namespace Tire_Pressure_Monitoring_System
{
    public interface IAlarm
    {
        bool AlarmOn { get; }

        void Check();
    }
}
