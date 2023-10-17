using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Datos
{
    public class RepositorioDeCuadrados
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrados.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Cuadrados.bak";

        private List<Cuadrado> listaCuadrados;

        public RepositorioDeCuadrados()
        {
            listaCuadrados = new List<Cuadrado>();
            LeerDatos();
        }
        public List<Cuadrado> GetLista()
        {
            return listaCuadrados;
        }
        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Cuadrado cuadrado = ConstuirCuadrado(lineaLeida);
                    listaCuadrados.Add(cuadrado);
                }
                lector.Close();

            } 
        }
        public void Editar(int ladoAnterior, Cuadrado cuadradoEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor=new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida=lector.ReadLine();
                        Cuadrado cuadrado = ConstuirCuadrado(lineaLeida);
                        if (ladoAnterior!=cuadrado.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(cuadradoEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }
        private Cuadrado ConstuirCuadrado(string? lineaLeida)
        {
            //"10"
            var campos=lineaLeida.Split('|');
            //campos[0]="10"
            int lado = int.Parse(campos[0]);
            Cuadrado c = new Cuadrado(lado);
            return c;

        }

        public void Agregar(Cuadrado cuadrado)
        {
            //using (var escritor = new StreamWriter(_archivo, true))
            //{
            //    string lineaEscribir = ConstruirLinea(cuadrado);
            //    escritor.WriteLine(lineaEscribir);

            //}
            var escritor = new StreamWriter(_archivo, true);

            string lineaEscribir = ConstruirLinea(cuadrado);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();
            

            listaCuadrados.Add(cuadrado);

        }

        private string ConstruirLinea(Cuadrado cuadrado)
        {
            return $"{cuadrado.GetLado()}";
        }
        /// <summary>
        /// Metodo para informar la cantidad de datos del repo
        /// </summary>
        /// <returns></returns>
        public int GetCantidad()
        {
            return listaCuadrados.Count;
        }
        public void Borrar(Cuadrado cuadradoBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Cuadrado cuadradoLeido = ConstuirCuadrado(lineaLeida);
                        if (cuadradoBorrar.GetLado()!=cuadradoLeido.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }

                    }
                }

            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaCuadrados.Remove(cuadradoBorrar);
        }
    }
}