namespace Prueba01
{
    class Mezclador : VehiculoComponentes
    {
        public enum Tipo
        {
            CARBURADOR, INYECTOR
        };
        private Tipo _tipoMezclador;
        public Mezclador(int tipo, float estadoComponente)
        {
            _estadoComponente = estadoComponente;
            switch (tipo)
            {
                case 1:
                    _tipoMezclador = Tipo.CARBURADOR;
                    break;
                case 2:
                    _tipoMezclador = Tipo.INYECTOR;
                    break;
            }
        }
        //Salida
        public
        override string ToString()
        {
            return "Mezclador: \n"
                + "     Tipo: "
                + _tipoMezclador.ToString()
                + "\n     Estado del componente: "
                + _estadoComponente
                + "%"
                + "\n";
        }
    }
}
