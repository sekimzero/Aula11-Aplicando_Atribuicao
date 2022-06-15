using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atribuicao
{
    internal class AtualizacaoDeFilmes : ListaDeFilmes
    {
        public String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string filme)
        {

            listaDeFilmes[indiceDoFilme] = filme;
            Console.WriteLine(filme);
            return listaDeFilmes;
        }

        public String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            return listaDeFilmes.Append(nomeDoFilme).ToArray();
        }
    }
}

