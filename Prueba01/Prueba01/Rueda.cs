using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Prueba01
{
    class Rueda : VehiculoComponentes
    {
        //Declaracion de variables
         public enum Recubrimiento{
            FENOL, HULE, POLIURETANO
        };
        private int [] _durometro = new int[2];
        private Recubrimiento _recubrimiento;
        //constructor
        public Rueda(int recubrimiento, int durometroMin, int durometroMax, float estadoComponente)
        {
            _estadoComponente = estadoComponente;
            _durometro[0] = durometroMin;
            _durometro[1] = durometroMax;
            switch (recubrimiento)
            {
                case 1:
                    _recubrimiento = Recubrimiento.FENOL; break;
                case 2:
                    _recubrimiento = Recubrimiento.HULE; break;
                case 3:
                    _recubrimiento = Recubrimiento.POLIURETANO; break;
                default:
                    _recubrimiento = Recubrimiento.POLIURETANO; break;
            }
        }
        //metodo de salida
        public
        override string ToString()
        {
            return "Ruedas: \n"
                + "     Recubrimiento de: "
                + _recubrimiento.ToString()
                + "\n     Durometro: "
                + _durometro[0]
                + "-"
                + _durometro[1]
                + "\n     Estado del componente: "
                + _estadoComponente
                + "%"
                + "\n";
        }
    }
}
