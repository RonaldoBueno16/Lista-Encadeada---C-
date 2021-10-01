using Lista_Encadeada.Models;
using System;

namespace Lista_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Node teste1 = new Node(1);
            Node teste2 = new Node(2);
            Node teste3 = new Node(3);
            Node teste4 = new Node(4);
            Node teste5 = new Node(5);
            Node teste6 = new Node(6);
            Node teste7 = new Node(7); 
            Node teste8 = new Node(8);
            Node teste9 = new Node(9);
            Node teste10 = new Node(12323);
            Node teste11 = new Node(123123123);

            ListaEncadeada lista = new ListaEncadeada();
            lista.InsertNode(teste1);
            lista.InsertNode(teste2);
            lista.InsertNode(teste3);
            lista.InsertNode(teste4);
            lista.InsertNode(teste5);
            lista.InsertNode(teste6);
            lista.InsertNode(teste7);
            lista.InsertNode(teste11);
            lista.InsertNode(teste8);
            lista.InsertNode(teste9);
            lista.InsertNode(teste10);
            Console.WriteLine(lista);
        }
    }
}
