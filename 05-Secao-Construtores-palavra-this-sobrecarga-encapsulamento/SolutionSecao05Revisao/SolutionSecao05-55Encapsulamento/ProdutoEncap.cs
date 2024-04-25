using System.Globalization;

namespace SolutionSecao05Revisao;

public class ProdutoEncap
{
    private string _nome;
            public double Preco { get; private set; }
            public double Quantidade { get; set; }
            public ProdutoEncap() {
            }
            public ProdutoEncap(string nome, double preco, int quantidade) {
                _nome = nome;
                Preco = preco;
                Quantidade = quantidade;
            }
            public string Nome {
                get { return _nome; }
                set {
                    if (value != null && value.Length > 1) {
                        _nome = value;
                    }
                }
            }
            public double ValorTotalEmEstoque {
                get { return Preco * Quantidade; }
            }
            public void AdicionarProdutos(int quantidade) {
                Quantidade += quantidade;
            }
            public void RemoverProdutos(int quantidade) {
                Quantidade -= quantidade;
            }
            public override string ToString() {
                return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
            }
}