namespace Aula11_Atribuicao
{
   
    
      
        internal class Program
        {
            static void Main(string[] args)
            {
                Funcoes resposta = new Funcoes(ListaDeFilmes.listaDeFilmes);
                // Resultado esperado em sua solução.
                Console.WriteLine("---------- Resultados da Atividade ----------");

                // 1.1 Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
                Console.WriteLine($"1.1. Lista de todos os filmes separados por ponto e vírgula: {resposta.apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");

                // 1.2 Retorna o número 7.
                Console.WriteLine($"1.2. Retorna a quantidade de filmes da lista: {resposta.quantidadeTotalDeFilmes()}");

                // 1.3 Se o índice for 0, retorna Clube dos Cinco;
                Console.WriteLine($"1.3. Buscar um filme pelo indice: {resposta.buscarNomeDoFilmePeloIndice(0)}");

                // 1.4 Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
                Console.WriteLine($"1.4. Adiciona um filme pelo nome: {string.Join("; ", resposta.adicionaUmNovoFilmePeloSeuNome("Sexta -feira 13th"))}");

                // 1.5 Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
                Console.WriteLine($"1.5. Atualizar um filme pelo seu índice {string.Join("; ", resposta.atualizarUmFilmePeloSeuIndice(3, "Rocky III"))}");


                /* 1.6 Retorna 
                0 - Clube dos Cinco 
                1 - A Hora do Pesadelo 
                2 - Karatê Kid
                3 - Rocky III
                4 - Conan, o Bárbaro
                5 - Highlander
                6 - Sexta-feira 13th */

                Console.WriteLine("1.6. Listar todos os filmes com seu indice/posicao na lista:");

                String[] listaDeTodosOsFilmesComIndice = resposta.listarTodosOsFilmesComSeuIndiceNaLista();
                foreach (string filme in listaDeTodosOsFilmesComIndice)
                {
                    Console.WriteLine($"\t{filme}");
                }
            }
        }
    }

