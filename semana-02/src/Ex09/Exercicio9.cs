namespace Ex09
{
    internal class Pizza
    {
        public static void Main()
        {
            Console.WriteLine("Você deseja uma pizza? Envie “1” para calabresa, “2” para mussarela, “3” para portuguesa ou “0” caso esteja satisfeito");
            var pedido = Console.ReadLine();
            var fatias = 0;

            while(pedido == "1" || pedido == "2" || pedido == "3")
            {
                Console.WriteLine("Deseja uma nova fatia");
                pedido = Console.ReadLine();
                fatias++;
            }

            if(pedido == "0")
            {
                Console.WriteLine($"\nTotal de fatias: {fatias}");
            }

            if(pedido != "1" && pedido != "2" && pedido != "3" && pedido != "0")
            {
                Console.WriteLine("\nOpção incorreta, tente novamente");
            }
        }
    }
}
