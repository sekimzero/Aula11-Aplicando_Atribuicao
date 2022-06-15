namespace Aula11_Atribuicao
{
    internal class Menu : ListaDeFilmes
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Menu de opções: \r\n" +
                $"1 - Apresenta todos os filme separados por ; (ponto e vírgula) \r\n" +
                $"2 - Apresenta quantidade de filmes na lista \r\n" +
                $"3 - Busca o nome do filme de acordo com o seu índice \r\n" +
                $"4 - Adiciona um novo filme a lista pelo seu nome \r\n" +
                $"5 - Atualiza um filme a partir do seu índice na lista \r\n" +
                $"6 - Lista todos os filmes com o seu índice/posição na lista");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;

            }







        }
    }
}
