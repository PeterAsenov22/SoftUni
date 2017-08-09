namespace TirePressureSystem.Tests
{
    using System;
    using Moq;
    using NUnit.Framework;
    using Tire_Pressure_Monitoring_System;

    [TestFixture]
    public class SensorTests
    {
        [Test]
        [TestCase(1,22)]
        [TestCase(2.4,51)]
        public void TestSensorPopNextPressurePsiValue(double number, double output)
        {
            Mock<Random> mockRandom = new Mock<Random>();
            mockRandom.Setup(x => x.NextDouble()).Returns(number);
            Mock<Sensor> mockSensor = new Mock<Sensor>(mockRandom.Object);

            double nextPsiValue = Math.Round(mockSensor.Object.PopNextPressurePsiValue());

            Assert.AreEqual(output, nextPsiValue, "PopNextPressurePsiValue doesn't return correct number.");
        }
    }
}
