using System;
using System.Net;
namespace Source_Project3
{
    public class Temperature
    {
        public double ToFarenheit(Operations operations)
        {
            if(operations.Scale == Scales.Farenheit)
                return operations.Value;

            if(operations.Scale == Scales.Kelvin)
                operations.Value -= 273.25f;

            float result = (((operations.Value * 9) / 5) + 32);

            return Math.Round(result, 1, MidpointRounding.ToEven);
        }

        public double ToKelvin(Operations operations)
        {
            if(operations.Scale == Scales.Kelvin)
                return operations.Value;

            if(operations.Scale == Scales.Celsius)
            {
                float convertion = operations.Value + 273.15f;
                return Math.Round(convertion, 1, MidpointRounding.ToEven);
            }

            //Farenheit to Kelvin:
            float result = (((operations.Value - 32) * 5)  / 9) + 273.15f;
            return Math.Round(result, 1, MidpointRounding.ToEven);
        }

        public double ToCelsius(Operations operations)
        {
            if(operations.Scale == Scales.Celsius)
                return operations.Value;

            if(operations.Scale == Scales.Kelvin)
            {
                float Convertion = operations.Value - 273.15f;
                return Math.Round(Convertion, 1, MidpointRounding.ToEven);
            }
            
            float result = ((operations.Value - 32) * 5) / 9;
            return Math.Round(result, 1, MidpointRounding.ToEven);
        }
    }

}