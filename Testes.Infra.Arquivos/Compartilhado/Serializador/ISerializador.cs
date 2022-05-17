namespace Testes.Infra.Arquivos.Compartilhado.Serializador
{
    public interface ISerializador
    {
        DataContext CarregarDadosDoArquivo();

        void GravarDadosEmArquivo(DataContext dados);
    }
}
