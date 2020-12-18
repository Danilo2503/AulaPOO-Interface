using System;
using System.Collections.Generic;

namespace AulaPOO_Interface.classes
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal {get; set;}
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int codigo, Produto produto){
            carrinho.Find(x => x.Codigo == codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto){
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto){
            carrinho.Remove(produto);
        }

        public void Listar(){
            foreach(Produto p in carrinho){
                Console.WriteLine($"R$ {p.Preco,2} - {p.Nome}");
            }
        }
    }
}