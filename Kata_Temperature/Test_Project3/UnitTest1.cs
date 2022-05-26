using NUnit.Framework;
using Source_Project3;

namespace Test_Project3
{
    public class Tests
    {
        [Test]
        public void KelvinToFareheitWith255()
        {
            Operations objectOperations = new Operations()
            {
                Value = 255,
                Scale = Scales.Kelvin
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToFarenheit(objectOperations);

            Assert.AreEqual(-0.8,  result);
        }

        [Test]
        public void CelsiusToFareheitWith255()
        {
            Operations objectOperations = new Operations()
            {
                Value = 255,
                Scale = Scales.Celsius
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToFarenheit(objectOperations);

            Assert.AreEqual(491,  result);
        }

        [Test]
        public void FarenheitToFareheitWith75()
        {
            Operations objectOperations = new Operations()
            {
                Value = 75,
                Scale = Scales.Farenheit
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToFarenheit(objectOperations);

            Assert.AreEqual(75,  result);
        }
    }
}