namespace Numeros_Aleatorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroPredefinido = random.Next(1,10);
            int intento;
            int numeroIntentos = 0;

            Console.WriteLine("Adivina un numero entre 1 y 10: ");

            do
            {
                Console.Write("Introduce tu intento: ");
                intento = int.Parse(Console.ReadLine());
                numeroIntentos = numeroIntentos + 1;

                if (intento < numeroPredefinido)
                {
                    Console.WriteLine("El numero es mayor. Intenta de nuevo.");
                }
                else if (intento > numeroIntentos);
                {
                    Console.WriteLine("El numero es menor. Intenta de nuevo.");
                }
            } while (intento != numeroPredefinido);
        }
    }
}
