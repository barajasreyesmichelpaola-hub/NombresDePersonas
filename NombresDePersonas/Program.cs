namespace NombresDePersonas
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] nombres = { "michelle", "paulina", "Carlos" };

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Nombre en la posición {i}: {nombres[i]}");
            }
        }
    }
}