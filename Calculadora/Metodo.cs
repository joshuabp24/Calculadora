using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Metodo

    {
        Principal pr = new Principal();
        public double Multiplicar()
        {
            string si;
            double valor;           
            Console.WriteLine("Ingrese un valor para multiplicar");
            valor = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese otro valor por el cual multiplicar");
                valor = valor * Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es: " + valor + " ¿Desea multiplicar el resultado por otro numero (si/no)?");
                si = Console.ReadLine();
            }
            while (si == "Si" || si == "si");
            pr.Menu();
            return valor;
            

        }
        public double Dividir()
        {
            string si;
            double valor;
            Console.WriteLine("Ingrese un valor para dividir");
            valor = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese otro valor por el cual dividir");
                valor = valor / Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es: " + valor + " ¿Desea dividir el resultado por otro numero (si/no)?");
                si = Console.ReadLine();
            }
            while (si == "Si" || si == "si");
            pr.Menu();
            return valor;
            
        }
        public double Sumar()
        {
            string si;
            double valor;
            Console.WriteLine("Ingrese un valor para sumar");
            valor = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese otro valor con el cual sumar");
                valor = valor + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es: " + valor + " ¿Desea sumar el resultado con otro numero (si/no)?");
                si = Console.ReadLine();
            }
            while (si == "Si" || si == "si");
            pr.Menu();
            return valor;

        }
        public double Restar()
        {
            string si;
            double valor;
            Console.WriteLine("Ingrese un valor para restar");
            valor = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese otro valor por el cual restar");
                valor = valor - Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es: " + valor + " ¿Desea restar el resultado con otro numero (si/no)?");
                si = Console.ReadLine();
            }
            while (si == "Si" || si == "si");
            pr.Menu();
            return valor;
        }
    }
}
