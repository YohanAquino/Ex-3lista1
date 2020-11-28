using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Calcular e exibir a área de um quadrado a partir do valor de sua diagonal que será digitado.
            Quadrado qua = new Quadrado();

            Console.WriteLine("digite a diagonal do quadrado:");
            qua.setDiagonal(double.Parse(Console.ReadLine()));

            qua.calcularArea();
            Console.WriteLine("A área do quadrado é {0}", qua.getArea());
            Console.ReadKey();
        }
    }
}
