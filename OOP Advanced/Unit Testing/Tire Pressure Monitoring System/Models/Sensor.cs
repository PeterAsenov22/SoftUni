namespace Tire_Pressure_Monitoring_System
{
    using System;

    public class Sensor : ISensor
    {
        const double Offset = 16;
        public readonly Random randomPressureSampleSimulator;

        public Sensor(Random randomPressureSampleSimulator)
        {
            this.randomPressureSampleSimulator = randomPressureSampleSimulator;
        }

        public double PopNextPressurePsiValue()
        {
            double pressureTelemetryValue = ReadPressureSample();

            return Offset + pressureTelemetryValue;
        }

        private double ReadPressureSample()
        {
            // Simulate info read from a real sensor in a real tire
            return 6 * randomPressureSampleSimulator.NextDouble() * randomPressureSampleSimulator.NextDouble();
        }
    }
}
