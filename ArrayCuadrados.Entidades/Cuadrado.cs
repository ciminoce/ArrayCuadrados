namespace ArrayCuadrados.Entidades
{
    //Esta es la clase
    public class Cuadrado:ICloneable
    {
        //Atributos de la clase
        private const int _CantidadLados = 4;
        private int _medidaLado;
        private TipoDeBorde tipoDeBorde;

        public TipoDeBorde TipoDeBorde
        {
            get { return tipoDeBorde; }
            set { tipoDeBorde = value; }
        }

        private ColorRelleno colorRelleno;

        public ColorRelleno ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; }
        }

        //Constructores
        public Cuadrado()
        {
            
        }
        public Cuadrado(int MedidaLado, TipoDeBorde borde, ColorRelleno color) {

            _medidaLado = MedidaLado;
            TipoDeBorde = borde;
            ColorRelleno = color;
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}