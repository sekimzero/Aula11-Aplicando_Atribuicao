
namespace Aula11_Atribuicao
{
    internal class Apresentacao : ListaDeFilmes
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
        public string listarTodosOsFilmesComSeuIndiceNaLista()
        {
            string lista = "";
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                lista += ($"    indice:{i} -  conteudo:{listaDeFilmes[i]}; \r\n");
            }
            return lista;

        }

        public int apresentarQuantidadeDeFilmes()
        {
            return listaDeFilmes.Length;
        }

    }
}

