using NUnit.Framework;
using Source_Project;

namespace Test_Project
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CelsiusToFarenheitWith0()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToFarenheit(0, Scales.celsius);
            Assert.AreEqual(32, result);
        }

        [Test]
        public void CelsiusToFarenheitWith100()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToFarenheit(100, Scales.celsius);
            Assert.AreEqual(212, result);
        }

        [Test]
        public void KelvinToFarenheitWith100()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToFarenheit(100, Scales.kelvin);
            Assert.AreEqual(-279, result);
        }

        [Test]
        public void FarenheitToFarenheitWith0()
        {
             TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToFarenheit(0, Scales.farenheit);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void FarenheitToCelsiusWith255()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToCelsius(255, Scales.farenheit);
            Assert.AreEqual(123, result);
        }

        [Test]
        public void CelsiusToCelsiusWith100()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToCelsius(0, Scales.celsius);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void KelvinToCelsiusWith255()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToCelsius(255, Scales.kelvin);
            Assert.AreEqual(-18, result);
        }

        [Test]
        public void FarenheitToKelvinWith163()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToKelvin(163, Scales.farenheit);
            Assert.AreEqual(345, result);
        }

        [Test]
        public void CelsiusToKelvinWith163()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToKelvin(163, Scales.celsius);
            Assert.AreEqual(436, result);
        }

        [Test]
        public void KelvinToKelvinWith163()
        {
            TemperatureOperations operations = new TemperatureOperations();
            var result = operations.ToKelvin(163, Scales.kelvin);
            Assert.AreEqual(163, result);
        }

        [Test]
        public void AddFarenheitAndKelvin()
        {
            TemperatureOperations operations = new TemperatureOperations(){
                Value = 163,
                Scale = 2
            };
            var result = operations.Add(512, Scales.kelvin);
            Assert.AreEqual(461, result);
        }
    }
}