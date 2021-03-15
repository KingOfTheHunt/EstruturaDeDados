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
                        Contains(linkedList);
                        break;
                    case '4':
                        Console.WriteLine(linkedList);
                        break;
                    case '5':
                        Console.WriteLine("Qtd. de elementos: " + linkedList.Count);
                        break;
                    case '6':
                        Console.WriteLine("Fim do programa!!!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (op != '6');
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("1 - Adicionar um elemento no ínicio da lista.");
            Console.WriteLine("2 - Adicionar um elemento no final da lista.");
            Console.WriteLine("3 - Verifica se há um elemento na lista.");
            Console.WriteLine("4 - Mostrar a lista.");
            Console.WriteLine("5 - Mostrar o tamanho da lista.");
            Console.WriteLine("6 - Sair");
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

        private static void Contains(LinkedList<double> linkedList)
        {
            try
            {
                Console.WriteLine();
                Console.Write("Digite um número: ");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Contém? { linkedList.Contains(num)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
