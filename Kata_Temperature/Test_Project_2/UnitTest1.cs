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

        [Test]
        public void KelvinToFarenheitWith212()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 212,
                Scale = Scale.Kelvin
            };
            
            var convertor = new Convertion();
            int result = convertor.ToFarenheit(temperature);

            Assert.AreEqual(-78, result);
        }

        [Test]
        public void CelsiusToFarenheitWith38()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 38,
                Scale = Scale.Celsius
            };
            
            var convertor = new Convertion();
            int result = convertor.ToFarenheit(temperature);

            Assert.AreEqual(100, result);
        }

        [Test]
        public void FarenheitToFarenheitWith38()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 38,
                Scale = Scale.Farenheit
            };
            
            var convertor = new Convertion();
            int result = convertor.ToFarenheit(temperature);

            Assert.AreEqual(38, result);
        }

        [Test]
        public void FarenheitToKelvinWith38()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 38,
                Scale = Scale.Farenheit
            };
            
            var convertor = new Convertion();
            int result = convertor.ToKelvin(temperature);

            Assert.AreEqual(276, result);
        }

        [Test]
        public void CelsiusToKelvinWith38()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 38,
                Scale = Scale.Celsius
            };
            
            var convertor = new Convertion();
            int result = convertor.ToKelvin(temperature);

            Assert.AreEqual(311, result);
        }

        [Test]
        public void KelvinToKelvinWith38()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 38,
                Scale = Scale.Kelvin
            };
            
            var convertor = new Convertion();
            int result = convertor.ToKelvin(temperature);

            Assert.AreEqual(38, result);
        }

        [Test]
        public void CelsiusAndKelvinAddition()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 27,
                Scale = Scale.Celsius
            };

            TemperatureOperations secondTemperature = new TemperatureOperations(){
                Value = 38,
                Scale = Scale.Kelvin
            };

            int result = temperature.Add(secondTemperature);
            Assert.AreEqual(-208, result);
        }

        [Test]
        public void CelsiusAndFarenheitSubstraction()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 78,
                Scale = Scale.Farenheit
            };

            TemperatureOperations secondTemperature = new TemperatureOperations(){
                Value = 27,
                Scale = Scale.Celsius
            };

            int result = temperature.Substraction(secondTemperature);
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void CelsiusAndCelsiusMultiplication()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 78,
                Scale = Scale.Celsius
            };

            TemperatureOperations secondTemperature = new TemperatureOperations(){
                Value = 27,
                Scale = Scale.Celsius
            };

            int result = temperature.Multiplication(secondTemperature);
            Assert.AreEqual(2106, result);
        }

        [Test]
        public void FarenheitAndKelvinDivision()
        {
            TemperatureOperations temperature = new TemperatureOperations(){
                Value = 78,
                Scale = Scale.Farenheit
            };

            TemperatureOperations secondTemperature = new TemperatureOperations(){
                Value = 15,
                Scale = Scale.Kelvin
            };

            double result = temperature.Division(secondTemperature);
            Assert.AreEqual(0.2, result);
        }
    }
}