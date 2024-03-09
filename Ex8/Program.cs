namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número
            Console.Write("Por favor, ingresa un número: ");

            // Lee la línea de entrada del usuario y la convierte en un entero
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica si el número es par o no
            if (numero % 2 == 0)
            {
                Console.Write("El número ingresado es par.");
            }
            else
            {
                Console.Write("El número ingresado es impar.");
            }

            // Espera a que el usuario presione una tecla antes de cerrar
            Console.Write("FINAL, FINAL, NO DA MAS...");
           
        }
    }
}