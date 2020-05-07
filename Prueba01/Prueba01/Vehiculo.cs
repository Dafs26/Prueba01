using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    abstract class Vehiculo : VehiculoComponentes
    {
        public Motor _motor;
        public Estanque _estanque;
        public Mezclador _mezclador;
        public Rueda _rueda;
    }
}
