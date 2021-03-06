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

        //Kelvin
        [Test]
        public void KelvintoKelvinWith75()
        {
            Operations objectOperations = new Operations()
            {
                Value = 75,
                Scale = Scales.Kelvin
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToKelvin(objectOperations);

            Assert.AreEqual(75,  result);
        }

        [Test]
        public void CelsiustoKelvinWit26()
        {
            Operations objectOperations = new Operations()
            {
                Value = 26,
                Scale = Scales.Celsius
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToKelvin(objectOperations);

            Assert.AreEqual(299.1,  result);
        }

        [Test]
        public void FarenheittoKelvinWit26()
        {
            Operations objectOperations = new Operations()
            {
                Value = 26,
                Scale = Scales.Farenheit
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToKelvin(objectOperations);

            Assert.AreEqual(269.8,  result);
        }

        [Test]
        public void CelsiusToCelsiusWit26()
        {
            Operations objectOperations = new Operations()
            {
                Value = 26,
                Scale = Scales.Celsius
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToCelsius(objectOperations);

            Assert.AreEqual(26,  result);
        }

        [Test]
        public void FarehenheitToCelsiusWit74()
        {
            Operations objectOperations = new Operations()
            {
                Value = 74,
                Scale = Scales.Farenheit
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToCelsius(objectOperations);

            Assert.AreEqual(23.3,  result);
        }

        [Test]
        public void KelvinToCelsiusWit300()
        {
            Operations objectOperations = new Operations()
            {
                Value = 300,
                Scale = Scales.Kelvin
            };

            Temperature temperatureConvertor =  new Temperature();
            double result = temperatureConvertor.ToCelsius(objectOperations);

            Assert.AreEqual(26.9, result);
        }
    }
}