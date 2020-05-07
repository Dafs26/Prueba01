using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Prueba01
{
    class Program {
        static void Main(string[] args)
        {
            bool Acceso;
            int opcion;
            Automovil auto;            
            ArrayList autos = new ArrayList();
            Console.WriteLine("Bienvenido");
            Acceso = Usuario.InicioSesion();            
            while (Acceso)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("\n1.Agregar Auto        2.Ver registro de autos        0. Cerrar sesion");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:
                        auto = Usuario.CrearAuto();
                        Usuario.IngresoDatosMotor(auto);
                        Usuario.IngresoDatosEstanque(auto);
                        Usuario.IngresoDatosMezclador(auto);
                        Usuario.IngresoDatosRueda(auto);
                        //Descomentar para probar con datos preestablecidos
                        //auto._motor = new Motor(123, 2, 2000, 50.5f);
                        //auto._estanque = new Estanque(50.0f,25.0f,90.0f);
                        //auto._mezclador = new Mezclador(1, 70.0f);
                        //auto._rueda = new Rueda(3, 150, 180, 40f);
                        //autos.Add(auto);
                        autos.Add(auto);
                        break;
                    case 2:
                        foreach(object informe in autos)
                            Console.WriteLine(informe);
                        break;
                    case 0:
                        Acceso = false;
                        break;

                }
            }
        }
    }
}
