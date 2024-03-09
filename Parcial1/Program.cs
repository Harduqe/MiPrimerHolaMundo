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
        }
    }
}
