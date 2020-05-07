using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    abstract class VehiculoComponentes
    {
        protected float _estadoComponente;

        protected float EstadoComponente()
        {
            float EstadoComponente;
            do
            {
                EstadoComponente = float.Parse(Console.ReadLine());
            } while (EstadoComponente > 100.0f || EstadoComponente < 0f);
            return EstadoComponente;
        }
    }
}
