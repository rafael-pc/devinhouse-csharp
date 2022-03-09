namespace Ex03
{
    internal class Name
    {
        public static void Main()
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            var sobrenome = Console.ReadLine();

            Console.WriteLine($"Meu nome é {nome} {sobrenome}");
        }
    }
}
