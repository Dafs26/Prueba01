using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Prueba01
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private int _año;
        private float _kilometraje;
        public Automovil(string marca, int año, float kilometraje)
        {
            _marca = marca;
            _año = año;
            _kilometraje = kilometraje;
        }
        public
        override string ToString()
        {
            return "Datos del automovil: \n"
                + "     Marca :"
                + _marca
                + "\n     Año: "
                + _año
                + "\n     Kilometraje: "
                + _kilometraje          + "\n \n"
                + _motor.ToString()     + "\n"
                + _mezclador.ToString() + "\n"
                + _estanque.ToString()  + "\n"
                + _rueda.ToString()     + "\n";
        }
    }
}
