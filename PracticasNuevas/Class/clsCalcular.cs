using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasNuevas.Class
{
    internal class clsCalcular
    {
        public string CalculateSum(int number1, int number2)
        {
            string result;
            int suma = number1 + number2;
            result = $"El resultado es: {suma}";
            return result;
        }
    }
}
