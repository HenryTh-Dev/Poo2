using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2.Exercicio_5
{
    internal class Conversor
    {

        //multiplicar a temperatura em graus Celsius por 1,8 e somar 32.
        public double ConventerEmFahrenheit(double temperatura)
        {
            temperatura = (temperatura * 1.8) + 32;
            return temperatura;
        }


        public double ConventerEmCelsius(double temperatura)
        {
            temperatura = (temperatura - 32) / 1.8 ;
            return temperatura;
        }
    }
}
