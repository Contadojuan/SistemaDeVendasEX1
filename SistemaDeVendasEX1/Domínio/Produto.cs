using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemaDeVendasEX1
{
    class Produto : IComparable //interface para comparar objetos
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return codigo + ", " + descricao + ", R$" +
            preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Produto outroProduto = (Produto)obj;
            int resultado = this.descricao.CompareTo(outroProduto.descricao);// se for igual, o CompareTo me retornará 0 = iguais, se primeiro menor
                                                                  //que o segundo, retornará valor negativo, se o segundo for maior, positivo
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                return -preco.CompareTo(outroProduto.preco); //o -preco significa que é ordem decrescente
            }
        }
    }
}
