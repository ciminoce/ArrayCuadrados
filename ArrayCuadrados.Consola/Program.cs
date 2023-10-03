using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Consola
{
    internal class Program
    {
        /*Almacenar el un array 5 alturas expresadas centimetros
         * Mostrar sus perimetros y sus superficies
         */
        static void Main(string[] args)
        {
            ////Definí un array de tipo Cuadrado
            //Cuadrado[] arrayCuadrados = new Cuadrado[3];
            //for (int i = 0; i < arrayCuadrados.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Ingrese la medida del {i + 1}º cuadrado:");
            //        var lado = int.Parse(Console.ReadLine());
            //        Cuadrado cuadradoCreado = new Cuadrado(lado);
            //        if (cuadradoCreado.Validar())
            //        {
            //            arrayCuadrados[i] = cuadradoCreado;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cuadrado no válido");
            //        }

            //    } while (true);
                


            //}
            //Console.WriteLine("Array Lleno!!!");
            //Console.Clear();
            //foreach (var item in arrayCuadrados)
            //{
            //    Console.WriteLine($"Cuadrado de lado {item.GetLado()} - Sup:{item.GetSuperficie()}");

            //}

            //Console.Write("Ingrese el nro de cuadrado a modificar:");
            ////Captura la posicion a modificar
            //var index = int.Parse(Console.ReadLine());
            ////Accedo al cuadrado que voy a modificar
            //var cuadradoEditar=arrayCuadrados[index];
            ////Ingreso la medida del lado
            //Console.Write("Ingrese nueva medida:");
            //var nuevaMedida = int.Parse(Console.ReadLine());
            ////Asigno la medida al cuadrado
            //cuadradoEditar.SetLado(nuevaMedida);

            //Console.Clear();
            //foreach (var item in arrayCuadrados)
            //{
            //    Console.WriteLine($"Cuadrado de lado {item.GetLado()} - Sup:{item.GetSuperficie()}");

            //}
            List<Cuadrado>lista=new List<Cuadrado>();
            lista.Add(new Cuadrado(2));
            lista.Add(new Cuadrado(10));
            lista.Add(new Cuadrado(5));
            Console.WriteLine(lista.Count);
            foreach (var item in lista)
            {
                Console.WriteLine(item.GetLado());
            }
            var cuadradoEdita = lista[1];
            cuadradoEdita.SetLado(100);
            foreach (var item in lista)
            {
                Console.WriteLine(item.GetLado());
            }
            lista.RemoveAt(1);
            Console.WriteLine(lista.Count);
        }
    }
}