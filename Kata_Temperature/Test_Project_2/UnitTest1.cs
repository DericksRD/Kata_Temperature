using NUnit.Framework;
using Source_Project_2;

namespace Test_Project_2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FarenheitToCelsiusWith32()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 32,
                Scale = Scale.Farenheit
            };
            
            var convertor = new Convertion();
            int result = convertor.ToCelsius(temperature);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void FarenheitToCelsiusWith212()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 212,
                Scale = Scale.Farenheit
            };
            
            var convertor = new Convertion();
            int result = convertor.ToCelsius(temperature);

            Assert.AreEqual(100, result);
        }

        [Test]
        public void KelviToCelsiusWith212()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 212,
                Scale = Scale.Kelvin
            };
            
            var convertor = new Convertion();
            int result = convertor.ToCelsius(temperature);

            Assert.AreEqual(-61, result);
        }
    }
}