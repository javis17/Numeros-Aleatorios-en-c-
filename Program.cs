namespace Numeros_Aleatorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroPredefinido = random.Next(1, 10);
            int intento;
            int numeroIntentos = 0;

            Console.WriteLine("Adivina un número entre 1 y 10:");

            do
            {
                Console.Write("Introduce tu intento: ");
                intento = int.Parse(Console.ReadLine());
                numeroIntentos = numeroIntentos + 1;

                if (intento < numeroPredefinido)
                {
                    Console.WriteLine("El número es mayor. Intenta de nuevo.");
                }
                else if (intento > numeroPredefinido)
                {
                    Console.WriteLine("El número es menor. Intenta de nuevo.");
                }

            } while (intento != numeroPredefinido);

            Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroPredefinido} después de {numeroIntentos} intentos.");
        }
    }
}