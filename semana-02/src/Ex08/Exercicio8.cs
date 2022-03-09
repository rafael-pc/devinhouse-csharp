namespace Ex08
{
    internal class Fatorial
    {
        public static void Main(int s)
        {
            decimal i, numero, fatorial;
            Console.WriteLine("Informe o número de 0 a 10");
            numero = Convert.ToDecimal(Console.ReadLine());

            fatorial = numero;

            if (numero > 0 && numero <= 10)
            {
                for (i = numero - 1; i >= 1; i--)
                {
                    fatorial = fatorial * i;
                }
                Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");
            }
            else
            {
            Console.WriteLine("\nValor invalido");
            }
        }
    }
}
