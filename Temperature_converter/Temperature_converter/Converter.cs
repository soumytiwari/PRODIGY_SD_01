using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_converter
{
    internal class Converter
    {
        public static double F_to_C(double F)
        {
            return (F - 32) * 5 / 9;
        }

        public static double C_to_F(double C)
        {
            return (C * 9 / 5) + 32;
        }

        public static double C_to_K(double C)
        {
            return C + 273.15;
        }

        public static double K_to_C(double K)
        {
            return K - 273.15;
        }

        public static double K_to_F(double K)
        {
            var ceslius = K_to_C(K);
            var fahrenheit = C_to_F(ceslius);
            return fahrenheit;
        }

        public static double F_to_K(double F)
        {
            var ceslius = F_to_C(F);
            var kelvin = C_to_K(ceslius);
            return kelvin;
        }

    }
}
