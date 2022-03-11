namespace Semana.Ex05
{
    internal class Arredondamento
    {
        public static void Main()
        {
            Console.WriteLine("Digite um numero com duas casas apos a virgula:");
            var numero = Convert.ToDouble(Console.ReadLine()) ;

            Console.WriteLine(Math.Round(numero, 0));
        }
    }
}
