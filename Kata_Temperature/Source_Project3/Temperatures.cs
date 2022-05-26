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

            double result = (((operations.Value * 9) / 5) + 32);

            return Math.Round(result, 1, MidpointRounding.ToEven);
        }
    }

}