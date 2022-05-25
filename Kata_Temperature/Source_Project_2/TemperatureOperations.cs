using System;
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

        public int ScaleConvertion(Scale myScale, TemperatureOperations operations)
        {
            int convertion = 0;

            var convertor = new Convertion();
            switch((int)Scale)
            {
                case 1:
                    convertion = convertor.ToCelsius(operations);
                    break;
                case 2:
                    convertion = convertor.ToFarenheit(operations);
                    break;
                case 3:
                    convertion = convertor.ToKelvin(operations);
                    break;
            }

            return convertion;
        }
        public int Add(TemperatureOperations operations)
        {
            int addition = ScaleConvertion(Scale, operations);

            return (int)Value + addition;
        }

        public int Substraction(TemperatureOperations operations)
        {
            int sub = ScaleConvertion(Scale, operations);

            return (int)Value - sub;
        }

        public int Multiplication(TemperatureOperations operations)
        {
            int multiply = ScaleConvertion(Scale, operations);

            return (int)Value * multiply;
        }

        public double Division(TemperatureOperations operations)
        {
            int div = ScaleConvertion(Scale, operations);

            return Math.Round(Value / div, MidpointRounding.AwayFromZero);
        }
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
