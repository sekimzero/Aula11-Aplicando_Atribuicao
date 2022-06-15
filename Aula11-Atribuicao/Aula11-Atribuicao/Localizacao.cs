
namespace Aula11_Atribuicao
{
    internal class Localizacao : Apresentacao
    {
        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return listaDeFilmes[indiceDoFilme];
        }        
    }
}
