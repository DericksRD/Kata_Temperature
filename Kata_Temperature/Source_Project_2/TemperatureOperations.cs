using System.Reflection.Emit;
namespace Source_Project_2
{
    public enum Scale
    {
        Celsius = 1,
        Farenheit = 2,
        Kelvin = 3
    }

    public class TemperatureOperations
    {
        public float Value {get; set;}
        public Scale Scale {get; set;}
    }

    public class Convertion
    {
        public int ToCelsius(TemperatureOperations operations)
        {
            if((int)operations.Scale == 3)
            {
                float convertion = operations.Value - 273.15f;
                return (int)convertion;
            }

            int result = (int)(((operations.Value - 32) * 5) / 9);
            return result;
        }

        public int ToFarenheit(TemperatureOperations operations)
        {
            if(operations.Scale == Scale.Farenheit)
                return (int)operations.Value;

            if(operations.Scale == Scale.Kelvin)
                operations.Value -= 273.15f;

            int result = (int)(((operations.Value * 9) / 5) + 32);
            return result;
        }

        public int ToKelvin(TemperatureOperations operations)
        {
            if(operations.Scale == Scale.Kelvin)
                return (int)operations.Value;

            if(operations.Scale == Scale.Celsius)
            {
                float celsiusReturn = operations.Value + 273.15f;
                return (int)celsiusReturn;
            }
            
            //Farenheit
            float result = (((operations.Value - 32) * 5) / 9) + 273.15f;
            return (int)result;
        }
    }
}
