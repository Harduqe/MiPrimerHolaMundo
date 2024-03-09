namespace Parcial1_Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX.Además, recibe una comisión del 10 % sobre el valor total de cada venta que realiza.El vendedor desea saber:  ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?  ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?  ¿Cuál fue la venta que le generó la mayor comisión?  ¿Cuál fue el promedio de las comisiones que recibió por cada venta? Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde indique si ganó o no el beneficio.
            
            // Solicitar el sueldo base al vendedor
            Console.Write("Ingrese el sueldo base del vendedor: $");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());

            // Inicializar variables
            double objetivoVentas = 1000000;
            double beneficioExtra = 100000;
            double totalVentas = 0;
            double mayorComision = 0;

            // Venta 1
            Console.Write("Ingrese el monto de la venta 1: $");
            double venta1 = Convert.ToDouble(Console.ReadLine());
            double comision1 = venta1 * 0.10;
            totalVentas += venta1;
            if (comision1 > mayorComision)
            {
                mayorComision = comision1;
            }

            // Venta 2
            Console.Write("Ingrese el monto de la venta 2: $");
            double venta2 = Convert.ToDouble(Console.ReadLine());
            double comision2 = venta2 * 0.10;
            totalVentas += venta2;
            if (comision2 > mayorComision)
            {
                mayorComision = comision2;
            }
            // Venta 3
            Console.Write("Ingrese el monto de la venta 3: $");
            double venta3 = Convert.ToDouble(Console.ReadLine());
            double comision3 = venta3 * 0.10;
            totalVentas += venta3;
            if (comision3 > mayorComision)
            {
                mayorComision = comision3;
            }

            // Calcular el total del mes con sueldo base y comisiones
            double totalMes = sueldoBase + (totalVentas * 0.10);

            // Verificar si se alcanzó el objetivo de ventas para el beneficio extra
            double totalMesConBeneficio = totalMes + (alcanzoObjetivo(totalVentas, objetivoVentas) ? beneficioExtra : 0);

            // Calcular el promedio de las comisiones por venta
            double promedioComisiones = (totalVentas * 0.10) / 3;

            // Mostrar resultados
            Console.Write($"Comisiones por las tres ventas: ${totalVentas * 0.10}");
            Console.Write($"Total del mes sin beneficio: ${totalMes}");
            Console.Write($"Venta que generó la mayor comisión: ${mayorComision}");
            Console.Write($"Promedio de comisiones por venta: ${promedioComisiones}");

            if (alcanzoObjetivo(totalVentas, objetivoVentas))
            {
                Console.Write("¡Felicidades! Has alcanzado el objetivo de ventas y ganado el beneficio extra.");
                Console.Write($"Total del mes con beneficio: ${totalMesConBeneficio}");
            }
            else
            {
                Console.WriteLine("No alcanzaste el objetivo de ventas para el beneficio extra.");
            }
        }
        static bool alcanzoObjetivo(double ventas, double objetivo)
        {
            return ventas >= objetivo;
        }
    }
}
