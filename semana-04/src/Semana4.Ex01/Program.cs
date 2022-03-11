namespace Funcionario
{
    public class Pessoa
    {
        private static string _nome;
        private static string _data_de_nascimento;
        private static double _altura;

        public static string Nome { get => _nome; set => _nome = "Rafael"; }
        public static string Data_de_nascimento { get => _data_de_nascimento; set => _data_de_nascimento = "16/10/1990"; }
        public static double Altura { get => _altura; set => _altura = 1.68; }

        public static string PessoaCaracteristicas()
        {
            return $"Nome: {Nome}, DataDeNascimento: {Data_de_nascimento}, Altura: {Altura}";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
