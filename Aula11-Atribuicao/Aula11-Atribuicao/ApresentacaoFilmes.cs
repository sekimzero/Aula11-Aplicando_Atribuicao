
namespace Aula11_Atribuicao
{
    internal class ApresentacaoFilmes : ListaDeFilmes
    {

        // 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
        public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            string lista = " ";
            Console.WriteLine(lista);
            for (int indice = 0; indice < listaDeFilmes.Length; indice++)
            {
                lista += $"{listaDeFilmes[indice]}";
                if (indice != (listaDeFilmes.Length - 1))
                {
                    lista += "; ";
                }
            }
            return lista;
        }

        // 1.6. Listar todos os filmes com seu índice/posição na lista.
        public String[] listarTodosOsFilmesComSeuIndiceNaLista()
        {
            string[] listaComIndice = new string[listaDeFilmes.Length];
            int count;
            for (count = 0; count < listaDeFilmes.Length; count++)
            {
                listaComIndice[count] = $"{count} - {listaDeFilmes[count]}";
            }

            return listaComIndice;

        }

    }
}

