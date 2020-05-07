using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    class Motor : VehiculoComponentes
    {
        // enumeracion de tipos de motor
        public enum Tipo
        {
            DOS_TIEMPOS, CUATRO_TIEMPOS
        };
        //declaracion de variables 
        private int _id;
        private Tipo _tipo;
        private int _cilindrada;
        //constructor
        public Motor(int id, int tipo, int cilindrada, float estadoComponente)
        {
            _id = id;
            _cilindrada = cilindrada;
            switch (tipo)
            {
                case 1:
                    _tipo = Tipo.DOS_TIEMPOS; break;
                case 2:
                    _tipo = Tipo.CUATRO_TIEMPOS; break;
            }
            _estadoComponente = estadoComponente;
        }
        //salida
        public
         override string ToString()
        {
            return "Motor: \n"
                + "     ID de Motor: "
                + _id
                + "\n     Tipo de Motor: "
                + _tipo
                + "\n     Cilindrada: "
                + _cilindrada
                + "cc"
                + "\n     Estado del componente: "
                + _estadoComponente
                + "%"
                + "\n";
        }
    }
}

