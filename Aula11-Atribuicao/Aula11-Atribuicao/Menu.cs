namespace Aula11_Atribuicao
{
    internal class Menu : Apresentacao
    {

        public void Main()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine(
                    $"Menu de opções: " + Environment.NewLine +
                    $"1 - Apresenta todos os filme separados por ; (ponto e vírgula)" + Environment.NewLine +
                    $"2 - Apresenta quantidade de filmes na lista " + Environment.NewLine +
                    $"3 - Busca o nome do filme de acordo com o seu índice" + Environment.NewLine +
                    $"4 - Adiciona um novo filme a lista pelo seu nome" + Environment.NewLine +
                    $"5 - Atualiza um filme a partir do seu índice na lista " + Environment.NewLine +
                    $"6 - Lista todos os filmes com o seu índice/posição na lista" + Environment.NewLine +
                    $"7 - Para finalizar o programa"
                    );
                int opcao = Convert.ToInt32(Console.ReadLine());
                Apresentacao filmes = new Apresentacao();
                Atualizacao filme = new Atualizacao();


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(filmes.apresentaTodosOsFilmesSeparadosPorPontoVirgula());
                        break;
                    case 2:
                        Console.WriteLine(filmes.apresentarQuantidadeDeFilmes());
                        break;
                    case 3:
                        Localizacao localizarFilme = new Localizacao();
                        Console.WriteLine("Digite o índice que você deseja localizar: ");
                        Console.WriteLine(localizarFilme.buscarNomeDoFilmePeloIndice(Convert.ToInt32(Console.ReadLine())));

                        break;
                    case 4:
                        Atualizacao filmePeloNome = new Atualizacao();
                        Console.WriteLine("Digite o nome do filme que você deseja adicionar: ");
                        Console.WriteLine(filmePeloNome.adicionaUmNovoFilmePeloSeuNome(Console.ReadLine()));
                        break;
                    case 5:
                        filme.atualizarUmFilmePeloSeuIndice();
                        break;
                    case 6:
                        Console.WriteLine(filmes.listarTodosOsFilmesComSeuIndiceNaLista());
                        break;
                    case 7:
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }

        }
    }
}
