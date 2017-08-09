namespace TirePressureSystem.Tests
{
    using Moq;
    using NUnit.Framework;
    using Tire_Pressure_Monitoring_System;

    [TestFixture]
    public class AlarmTests
    {
        [Test]
        [TestCase(3)]
        [TestCase(24)]
        [TestCase(16)]
        [TestCase(22)]
        public void TestAlarmOnShouldReturnTrue(int number)
        {
            Mock<ISensor> sensor = new Mock<ISensor>();
            sensor.Setup(p => p.PopNextPressurePsiValue()).Returns(number);
            Mock<Alarm> alarm = new Mock<Alarm>(sensor.Object);

            alarm.Object.Check();

            Assert.IsTrue(alarm.Object.AlarmOn);
        }

        [Test]
        [TestCase(17)]
        [TestCase(19)]
        [TestCase(21)]
        public void TestAlarmOnShouldReturnFalse(int number)
        {
            Mock<ISensor> sensor = new Mock<ISensor>();
            sensor.Setup(p => p.PopNextPressurePsiValue()).Returns(number);
            Mock<Alarm> alarm = new Mock<Alarm>(sensor.Object);

            alarm.Object.Check();

            Assert.IsFalse(alarm.Object.AlarmOn);
        }
    }
}
