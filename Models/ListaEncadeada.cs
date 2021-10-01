using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada.Models
{
    class ListaEncadeada
    {
        public Node primeiro { get; set; }
        public Node ultimo { get; set; }
        public int tamanho { get; set; }

        public ListaEncadeada()
        {
            this.tamanho = 0;
            this.primeiro = null;
            this.ultimo = null;
        }

        public void InsertNode(Node node)
        {
            if (this.tamanho == 0)
                this.primeiro = node;
            else
                this.ultimo.proximo = node;

            this.tamanho++;
            this.ultimo = node;
        }

        public override string ToString()
        {
            string retornar = "";

            var no = this.primeiro;

            while (true)
            {
                retornar += no.numero.ToString() + " ";

                no = no.proximo;
                if (no == null)
                    break;
            }

            return retornar;
        }
    }
}
