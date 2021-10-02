using Lista_Encadeada.Service;
using Lista_Encadeada.Models;
using System;

namespace Lista_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEncadeadaService lista = new ListaEncadeadaService();
            for (int x = 0; x < 10; x++)
            {
                Node no = new Node(x+600);
                lista.InsertNode(no);
            }

            Console.WriteLine(lista);
            lista.SetValueForNode(5, 500);
            Console.WriteLine(lista);
            lista.RemoveNodeIndex(0);
            lista.RemoveNodeIndex(0);
            lista.RemoveNodeIndex(0);
            Console.WriteLine(lista);
        }
    }
}
