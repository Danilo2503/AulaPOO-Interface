namespace AulaPOO_Interface.classes
{
    public interface ICarrinho
    {
        void Listar();
        void Cadastrar(Produto produto);
        void Alterar(int codigo, Produto produto);
        void Deletar(Produto produto);

    }
}