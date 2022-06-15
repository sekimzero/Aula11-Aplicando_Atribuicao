using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atribuicao
{
    internal class Funcoes
    {

        private string[] listaDeFilmes; 
        public Funcoes(string[] ListaDeFilmes)
        {
            this.listaDeFilmes = ListaDeFilmes;
        }


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

        // 1.2. Apresentar quantidade de filmes da lista.
        public int quantidadeTotalDeFilmes()
        {
            int quantidadeTotal = listaDeFilmes.Length;
            return quantidadeTotal;
        }


        // 1.3. Buscar o nome do filme de acordo com seu índice.
        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return listaDeFilmes[indiceDoFilme];
        }

        // 1.4. Adiciona um novo filme a lista pelo seu nome.
        public String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            return listaDeFilmes.Append(nomeDoFilme).ToArray();
        }

        // 1.5. Atualiza um filme a partir do seu índice na lista.

        public String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string filme)
        {

            listaDeFilmes[indiceDoFilme] = filme;
            Console.WriteLine(filme);
            return listaDeFilmes;
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
