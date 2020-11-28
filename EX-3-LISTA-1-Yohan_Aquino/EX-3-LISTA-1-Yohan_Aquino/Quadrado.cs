using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3_LISTA_1_Yohan_Aquino
{
    class Quadrado
    {
        private double d;
        private double a;

        public void setDiagonal(double x)
        {
            d = x;
        }

        public void calcularArea()
        {
            a = Math.Pow(d, 2)/2;
        }
        public double getArea()
        {
            return a;
        }

    }
}
