using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atribuicao
{
    internal class Atualizacao : Apresentacao
    {
        public void atualizarUmFilmePeloSeuIndice()
        {
            Console.WriteLine("Digite o índice para atualizar: ");
            int indiceDoFilme = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do filme para atualizar: ");
            string filme = Console.ReadLine();
            listaDeFilmes[indiceDoFilme] = filme;
            Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
        }

        public String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            return listaDeFilmes.Append(nomeDoFilme).ToArray();
        }
    
    }
}

