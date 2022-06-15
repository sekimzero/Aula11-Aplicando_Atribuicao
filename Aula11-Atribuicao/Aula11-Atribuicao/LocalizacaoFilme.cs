using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atribuicao
{
    internal class LocalizacaoFilme : ListaDeFilmes
    {
        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return listaDeFilmes[indiceDoFilme];
        }        
    }
}
