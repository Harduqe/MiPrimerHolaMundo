namespace Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad constante de 100 km / h. ¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora en pantalla

            // Velocidades de los trenes en km/h

            int v1 = 80; 
            int v2 = 100; 

            double t2 = CalcularTiempoAlcance(v1, v2); // Tiempo en horas que ha estado viajando el segundo tren

            DateTime inicio = new DateTime(2023, 1, 1, 10, 0, 0); // Hora de inicio del primer tren
            DateTime alcance = inicio.AddHours(t2); // Calcular la hora de alcance

            Console.WriteLine($"El segundo tren alcanzará al primero a las: {alcance.ToString("HH:mm tt")}");
        }

        static double CalcularTiempoAlcance(int v1, int v2)
        {
            double d = 1000000; // Distancia en km (ajustar según necesidades)
            return d / (v2 - v1); // Calcular el tiempo en horas que le toma al segundo tren alcanzar al primero
        }
    }
}
