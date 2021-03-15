using System;
using System.Text;

namespace EstruturaDeDados.Util
{
    class LinkedList<T>
    {
        // Aponta para o primeiro elemento da lista.
        private Node<T> _head;
        private Node<T> _tail;

        public int Count { get; private set; }

        public void AddAtTheBeginning(T value)
        {
            Node<T> node = new Node<T>();
            // Adicionado o valor ao node.
            node.Value = value;
            // Apontando para o próximo elemento da lista.
            node.NextNode = _head;
            // Fazendo a cabaça apontar para o novo node que foi criado.
            _head = node;

            if (Count == 0)
            {
                _tail = node;
            }

            Count++;
        }

        /// <summary>
        /// Adiciona o elemento ao final da lista.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            _tail.NextNode = node;
            _tail = node;

            Count++;
        }

        public bool Contains(T value)
        {
            if (Count == 0)
            {
                throw new Exception("Não é possível realizar esta operação, pois a lista está vazia.");
            }

            Node<T> current = _head;

            while (current.NextNode != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }

                current = current.NextNode;
            }

            return false;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[ ");

            // Recebe a referência para o primeiro elemento da lista.
            Node<T> current = _head;

            while (current != null)
            {
                builder.Append(current.Value + " ");
                // Recebe a referência para o próximo elemento da lista.
                current = current.NextNode;
            }

            builder.Append("]");

            return builder.ToString();
        }
    }
}
