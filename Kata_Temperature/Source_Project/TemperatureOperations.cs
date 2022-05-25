namespace Source_Project
{
    public enum Scales
    {
        celsius = 1,
        farenheit = 2,
        kelvin = 3
    }
    public class TemperatureOperations
    {
        public float Value;
        public int Scale;
        public int ToFarenheit(float value, Scales scale)
        {

            if((int)scale == 2)
                return (int)value;

            if((int)scale == 3)
                value -= 273.15f;
            
            float result = ((value * 9) / 5 ) + 32;
            return (int)result;
        }

        public int ToCelsius(float value, Scales scale)
        {
            if((int)scale == 1)
                return (int)value;

            if((int)scale == 3)
            {
                float kelvinResult = value - 273.15f;
                return (int)kelvinResult;
            }
            
            float result = ((value - 32) * 5) / 9;
            return (int)result;
        }

        public int ToKelvin(float value, Scales scale)
        {
            if((int)scale == 3)
                return (int)value;

            if((int)scale == 2)
            {
                float farenheitResult = (((value - 32) * 5) / 9) + 273.15f;
                return (int)farenheitResult;
            }

            float result = value + 273.15f;
            return (int)result;
        }

        public int Add(float value, Scales scale)
        {
            int insertedValue = 0;
            switch((int)Scale)
            {
                case 1:
                    insertedValue = ToCelsius(value, scale);
                    break;
                case 2:
                    insertedValue = ToFarenheit(value, scale);
                    break;
                case 3:
                    insertedValue = ToKelvin(value, scale);
                    break;
                default:
                    throw new System.Exception("El valor ingresado no es válido");
            }

            return (int)Value + insertedValue;
        }
    }
}