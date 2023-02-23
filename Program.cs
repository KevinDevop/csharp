using csharp.Models;

namespace csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TIPOS DE DATOS

            byte bytes = 255;
            Console.WriteLine(bytes);

            int numero = 333;
            Console.WriteLine(numero);

            bool afirmacion = true;
            Console.WriteLine(afirmacion);

            string texto = "Hola inmundo animal!";
            Console.WriteLine(texto);

            float flotantes = 121.0f;
            Console.WriteLine(flotantes);

            decimal decimales = 1201.5m;
            Console.WriteLine(decimales);

            //El signo hace la variable recibir null
            int? nullable = null;
            Console.WriteLine(nullable);

            var texto2 = "Hola";
            Console.WriteLine(texto2);

            var kevin = new { nombre = "Kevin", edad = 23, ciudad = "Barranquilla" };
            Console.WriteLine(kevin.edad);

            static string Mensaje(string nombre)
            {
                return $"Hola {nombre}";
            }


            Console.WriteLine(sumar(21 ,33));
            Console.WriteLine("-----------------------------Clases----------------------------");


            Bebida bebida = new("Postobón", 1500);
            Console.WriteLine(bebida.Nombre);
            Console.WriteLine(bebida.Cantidad);
            bebida.Beberse(190);
            Console.WriteLine(bebida.Cantidad);

            Console.WriteLine("---------------------------------------------------------------");

            Cerveza cerveza = new Cerveza();
            Console.WriteLine(cerveza.Nombre);
            Console.WriteLine(cerveza.Cantidad);
            cerveza.Beberse(123);
            Console.WriteLine(cerveza.Cantidad);
        }
        public static int sumar(int a, int b)
        {
            return a + b;
        }

     
    }
}













