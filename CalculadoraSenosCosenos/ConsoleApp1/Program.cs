using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Char opcion;
            String continuar;

            do
            {
                Console.WriteLine("|**************************************************************|");
                Console.WriteLine("|*                                                            *|");
                Console.WriteLine("|*           1.- Ley de cosenos (Obtener tercer lado LAL)     *|");
                Console.WriteLine("|*           2.- Ley de cosenos (Obtener un angulo LLL)       *|");
                Console.WriteLine("|*           3.- Ley de senos   (Obtener un angulo AAL)       *|");
                Console.WriteLine("|*                                                            *|");
                Console.WriteLine("|*           0.-Salir                                         *|");
                Console.WriteLine("|*                                                            *|");
                Console.WriteLine("|**************************************************************|");
                Console.Write("\n");
                Console.Write("Dime una opción: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '3');



                switch (opcion)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case '1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese el primer lado  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese el segundo lado (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese el ángulo opuesto al primer lado (y): ");
                            double numeroZ = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY, numeroZ);

                            Console.WriteLine("El ángulo opuesto : " + op.OpcionCosenoLAL().ToString());

                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese el primer lado: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese el segundo lado: ");
                            double numeroY = double.Parse(Console.ReadLine());
                            
                            Console.Write("Ingrese el tercer lado: ");
                            double numeroZ = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY, numeroZ);

                            Console.WriteLine("El ángulo opuesto al segundo lado ingresado es: " + op.OpcionCosenoLLL().ToString());

                        }
                        break;
                    case '3':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY, 0);

                            Console.WriteLine("El resultado de la multiplicación es: " + op.OpcionSenoAAL().ToString());

                        }
                        break;
                }

                Console.WriteLine("-------------------------------");
                Console.Write("¿Deseas continuar? y/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");

        }
    }
}
