using System;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Prueba01
{
    interface Usuario
    {
        private static string _usuario = "admin";
        private static string _contraseña = "abc123";
        private static bool Acceso(string usuario, string contraseña)
        {
            return usuario.Equals(_usuario) && contraseña.Equals(_contraseña);
        }
        public static bool InicioSesion()
        {
            string usuario;
            string contraseña;
            do
            {
                Console.WriteLine("\nIngrese usuario: ");
                usuario = (string) Console.ReadLine();
                Console.WriteLine("\nIngrese contraseña: ");
                contraseña = (string) Console.ReadLine();
            } while (!Usuario.Acceso(usuario,contraseña));
            Console.WriteLine("\nAcceso concedido \n");
            return true;
        }
        private static float EstadoPieza()
        {
            float estado;
            do
            {
                Console.WriteLine("\nEstado: %");
                estado = float.Parse(Console.ReadLine());
            } while (estado < 0f || estado > 100f);
            return estado;
        }
        public static Automovil CrearAuto()
        {

            string marca;
            int año;
            float kilometraje;
            Console.WriteLine("\nMarca: ");
            marca = Console.ReadLine();
            Console.WriteLine("\nAño: ");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("\nKilometraje (Km): ");
            kilometraje = float.Parse(Console.ReadLine());
            Automovil auto = new Automovil(marca, año, kilometraje);
            return auto;
        }
        public static void IngresoDatosMotor(Automovil auto)
        {
            int id;
            int eleccion;
            int cilindrada;
            float estado;
            int contador = 1;
            Console.WriteLine("Datos del motor: ");
            Console.WriteLine("\nID del motor: ");
            id = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("\nTipo de motor:");
                foreach (string tipo in Enum.GetNames(typeof(Motor.Tipo)))
                {
                    Console.WriteLine(contador + ". " + tipo);
                    contador++;
                }
                eleccion = int.Parse(Console.ReadLine());
            } while (eleccion < 1 || eleccion > 2);
            do
            {
                Console.WriteLine("\nCilindrada: ");
                cilindrada = int.Parse(Console.ReadLine());
            } while (cilindrada <= 0);
            Console.WriteLine("\nEstado del motor: %");
            estado = EstadoPieza();
            auto._motor = new Motor(id, eleccion, cilindrada, estado);
        }
        public static void IngresoDatosEstanque(Automovil auto)
        {
            float capacidad;
            float litros;
            float estado;
            Console.WriteLine("Datos del Estanque: ");
            do
            {
                Console.WriteLine("\nCapacidad: ");
                capacidad = float.Parse(Console.ReadLine());
                Console.WriteLine("\nLitros en estanque: ");
                litros = float.Parse(Console.ReadLine());
            } while (capacidad < litros || (capacidad<0 || litros<0));            
            estado = EstadoPieza();
            auto._estanque = new Estanque(capacidad, litros, estado);
        }
        public static void IngresoDatosMezclador(Automovil auto)
        {
            int eleccion;
            float estado;
            int contador = 1;
            Console.WriteLine("Datos del Mezclador: ");
            do
            {
                Console.WriteLine("\nTipo de motor:");
                foreach (string tipo in Enum.GetNames(typeof(Mezclador.Tipo)))
                {
                    Console.WriteLine(contador + ". " + tipo);
                    contador++;
                }
                eleccion = int.Parse(Console.ReadLine());
            } while (eleccion < 1 || eleccion > 2);
            estado = EstadoPieza();
            auto._mezclador = new Mezclador(eleccion, estado);
        }
        public static void IngresoDatosRueda(Automovil auto)
        {
            int recubrimiento;
            int durometroMin;
            int durometroMax;
            float estado;
            int contador = 1;
            Console.WriteLine("Datos de las Ruedas: ");
            do
            {
                Console.WriteLine("\nTipo de recubrimiento:");
                foreach (string tipo in Enum.GetNames(typeof(Rueda.Recubrimiento)))
                {
                    Console.WriteLine(contador + "." + tipo);
                    contador++;
                }
                recubrimiento = int.Parse(Console.ReadLine());
            } while (recubrimiento < 1 || recubrimiento > 3);
            do
            {
                Console.WriteLine("\nDurometro min: ");
                durometroMin = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDurometro max: ");
                durometroMax = int.Parse(Console.ReadLine());
            } while (durometroMax < durometroMin || (durometroMin<0 || durometroMax<0));
            estado = EstadoPieza();
            auto._rueda = new Rueda(recubrimiento, durometroMin, durometroMax, estado);
        }
    }
}
