using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Datos
{
    public class RepositorioDeCuadrados
    {
        private List<Cuadrado> listaCuadrados;

        public RepositorioDeCuadrados()
        {
            listaCuadrados = new List<Cuadrado>();
        }
        public void Agregar(Cuadrado cuadrado)
        {
            listaCuadrados.Add(cuadrado);
        }
        public int GetCantidad()
        {
            return listaCuadrados.Count;
        }
        public void Borrar(Cuadrado cuadrado)
        {
            listaCuadrados.Remove(cuadrado);
        }
    }
}