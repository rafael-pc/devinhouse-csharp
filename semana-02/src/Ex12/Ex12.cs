namespace Semana2.Ex12  
{
    class TIC_TAC_TOE
    {
        //criando array e
        //por padrão estou fornecendo 0-9 onde não há uso de zero
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //Por padrão o player 1 está definido
        static int choice; //Isso mantém a escolha em qual posição o usuário deseja marcar
        // A variável flag verifica quem ganhou se o valor for 1 então alguém ganhou a partida
        //se -1 então o jogo tem empate se 0 então o jogo ainda está em execução
        static int flag = 0;
        static void Main()
        {
            Console.Clear();
            Console.Write("Player 1: ");
            var player1 = Console.ReadLine();

            Console.Write("Player 2: ");
            var player2 = Console.ReadLine();
            do
            {
                Console.Clear();// sempre que o loop for novamente iniciado, a tela ficará limpa
                Console.WriteLine($"Player 1: {player1} - X");
                Console.WriteLine($"Player 2: {player2} - O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//verificando a chance do jogador
                {
                    Console.WriteLine($"{player2} Chance");
                }
                else
                {
                    Console.WriteLine($"{player1} Chance");
                }
                Console.WriteLine("\n");
                Board();//chamando a função board
                choice = Convert.ToInt32(Console.ReadLine());//Pegando a escolha dos usuários
                // verificando se a posição onde o usuário deseja executar está marcada (com X ou O) ou não
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //se a chance for do jogador 2 então marca O senão marca X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                // se houver alguma possibilidade em que o usuário deseja executar
                // e isso já está marcado então mostra a mensagem e carrega a board novamente
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin(); // chamada de check win
            }
            while (flag != 1 && flag != -1);
            // Este loop será executado até que todas as células da grade não estejam marcadas
            // com X e O ou algum jogador não ganha
            Console.Clear(); //limpando o console
            Board();// enchendo o tabuleiro novamente
            if (flag == 1)
            // se o valor do sinalizador for 1, então alguém ganhou ou
            // significa quem jogou marcou a última vez que ganhou
            {
                if ((player % 2) + 1 == 1)
                {
                    Console.WriteLine($"{player1} has won");
                }
                if ((player % 2) + 1 == 2)
                {
                    Console.WriteLine($"{player2} has won");
                }
            }
            // {
            //     Console.WriteLine("Player {0} has won", (player % 2) + 1);
            //     Console.WriteLine((player % 2) + 1);
            // }
            else // se o valor da flag for -1 a partida será empatada e ninguém é o vencedor
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Método de placa que cria board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
            Console.WriteLine("\n");
        }
        //Verificando se algum jogador ganhou ou não
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Condição vencedora para a primeira linha
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Condição vencedora para a segunda linha
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Condição vencedora para a terceira linha
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Condição vencedora para a primeira coluna
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Condição vencedora para a segunda coluna
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            // Condição vencedora para a terceira coluna
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // Se todas as células ou valores forem preenchidos com X ou O então qualquer jogador ganhou a partida
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}