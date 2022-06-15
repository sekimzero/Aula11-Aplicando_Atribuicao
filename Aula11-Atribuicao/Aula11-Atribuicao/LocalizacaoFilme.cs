
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
