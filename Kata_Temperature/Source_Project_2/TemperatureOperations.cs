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
    }
}
