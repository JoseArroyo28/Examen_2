using System;

namespace LibreriaConvertidor
{
    public class Class1
    {
        public static double fahrenheit(int Gradros){

            return Gradros *(9/5 ) + 32;
        }

        public static double Celsius(int Gradros)
        {
            float Aux = Gradros - 32;
            return Aux * (0.55);
        }
    }
}

