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
                        Console.WriteLine(linkedList);
                        break;
                    case '3':
                        Console.WriteLine("Fim do programa!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (op != '3');
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("1 - Adicionar um elemento a lista.");
            Console.WriteLine("2 - Mostrar a lista.");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
        }

        private static void AddElement(LinkedList<double> linkedList)
        {
            Console.WriteLine();
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            linkedList.AddAtTheBeginning(num);
        }
    }
}
