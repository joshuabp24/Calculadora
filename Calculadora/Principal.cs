using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Principal
    {

        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al programa, presiona enter para accesar al menu.");
            Console.ReadKey();
            Menu();
        }
        public void Menu()
        {
            Metodo Met = new Metodo();
            Console.WriteLine("Bienvenido al menu, ingresa 1- para sumar, 2- para restar, 3- para multiplicar, 4- para dividir o 5- para salir.");
            string Elec;
            Elec = Console.ReadLine();

            switch(Elec)               
            {
                case "1":
                    Met.Sumar();
                    break;
                case "2":
                    Met.Restar();
                    break;
                case "3":
                    Met.Multiplicar();
                    break;
                case "4":
                    Met.Dividir();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ingresaste un valor invalido, regresando al menu");
                    Menu();
                    break;
            }

        }
    }
}
