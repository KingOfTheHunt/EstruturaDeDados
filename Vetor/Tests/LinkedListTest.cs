using System;
using EstruturaDeDados.Util;

namespace EstruturaDeDados.Tests
{
    static class LinkedListTest
    {
        public static void Show()
        {
            LinkedList<double> linkedList = new LinkedList<double>();

            char op;

            do
            {
                Menu();
                op = Console.ReadLine()[0];

                switch (op)
                {
                    case '1':
                        AddElement(linkedList);
                        break;
                    case '2':
                        AddElementAtEnd(linkedList);
                        break;
                    case '3':
                        Console.WriteLine(linkedList);
                        break;
                    case '4':
                        Console.WriteLine($"{linkedList.Count} elementos.");
                        break;
                    case '5':
                        Console.WriteLine("Fim do programa!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (op != '5');
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("1 - Adicionar um elemento no ínicio da lista.");
            Console.WriteLine("2 - Adicionar um elemento no final da lista.");
            Console.WriteLine("3 - Mostrar a lista.");
            Console.WriteLine("4 - Mostrar o tamanho da lista.");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
        }

        private static void AddElement(LinkedList<double> linkedList)
        {
            Console.WriteLine();
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            linkedList.AddAtTheBeginning(num);
        }

        private static void AddElementAtEnd(LinkedList<double> linkedList)
        {
            Console.WriteLine();
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            linkedList.Add(num);
        }
    }
}
