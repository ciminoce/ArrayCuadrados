namespace ArrayCuadrados.Entidades
{
    //Esta es la clase
    public class Cuadrado
    {
        //Atributos de la clase
        private const int _CantidadLados = 4;
        private int _medidaLado;

        //Constructores
        public Cuadrado()
        {
            
        }
        public Cuadrado(int MedidaLado) {

            _medidaLado = MedidaLado;
            //if (MedidaLado>0)
            //{

            //}
            //else
            //{
            //    throw new ArgumentException("Medida del lado no válida");
            //}
        }
        //Métodos acceden a atributos
        public bool Validar()
        {
            return _medidaLado > 0;
        }
        public int GetLado() => _medidaLado;
        public void SetLado(int medida)
        {
            if(medida>0)
            {
                _medidaLado = medida;
            }
        }

        //Métodos de información
        public double GetPerimetro() => _CantidadLados * _medidaLado;
        public double GetSuperficie()=>Math.Pow(_medidaLado, 2);


    }
}