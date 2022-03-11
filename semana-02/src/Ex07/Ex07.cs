namespace Semana.Ex07
{
    internal class Media
    {
        public static void Main()
        {
            Console.WriteLine("Digite nota 1:");
            var nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite nota 2:");
            var nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite nota 3:");
            var nota3 = Convert.ToDecimal(Console.ReadLine());

            var media = ( nota1 + nota2 + nota3 ) / 3 ;

            Console.WriteLine($"Sua media final é {Math.Round(media, 2)}");
        }
    }
}
