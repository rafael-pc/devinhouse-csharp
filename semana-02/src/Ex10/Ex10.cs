namespace Semana.Ex10
{
    internal class Notas
    {
        public static void Main()
        {
            decimal[] notas = new decimal[10];
            decimal soma = 0;
            decimal nota;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Introduza um valor inteiro de 0 a 10");
                nota = Convert.ToDecimal(Console.ReadLine());
                if ((nota < 0) || (nota > 10))
                {
                    Console.WriteLine("O valor não está entre 0 a 10");
                    i--;
                }
                else
                {
                    notas[i] = nota;
                }
            }

            for (int i = 0; i < notas.Length; i++)
            {
                soma = soma + notas[i];
            }
            decimal media = soma / 10;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Média: " + media);

            decimal maior = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maior) maior = notas[i];
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Maior nota: " + maior);

            decimal menor = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < menor) menor = notas[i];
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Menor nota: " + menor);

            Console.WriteLine("------------------------------");
        }
    }
}