using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    class Estanque : VehiculoComponentes
    {
        // Declaracion de variables
        private float _capacidad;
        private float _litros;
        
        //constructor
        public Estanque(float capacidad, float litros, float estadoComponente)
        {
            _capacidad = capacidad;
            _litros = litros;
            _estadoComponente = estadoComponente;
        }
        //metodos
        private bool MitadCombustible ()
        {
            return (_litros / _capacidad > 0.15 && _litros / _capacidad <= 0.5);
        }
        private bool BajoCombustible()
        {
            return (_litros / _capacidad <= 0.15);
        }
        //Salida
        public
        override string ToString()
        {
            if (BajoCombustible())
                return "Estanque: \n"
                    + "     Capacidad: "
                    + _capacidad
                    + "L"
                    + "\n     Nivel de combustible: Bajo"
                    + "\n     Estado del componente: "
                    + _estadoComponente
                    + "%"
                    + "\n";
            else if (MitadCombustible())
                return "Estanque: \n"
                    + "     Capacidad: "
                    + _capacidad
                    + "L"
                    + "\n     Nivel de combustible: Medio"
                    + "\n     Estado del componente: "
                    +_estadoComponente
                    +"%"
                    + "\n";
            else
                return "Estanque: \n"
                    + "     Capacidad: "
                    + _capacidad
                    + "L"
                    + "\n     Nivel de combustible: Alto"
                    + "\n     Estado del componente: "
                    + _estadoComponente
                    + "%"
                    + "\n";
        }
    }
}
