using System.Text;

namespace EstruturaDeDados.Util
{
    class LinkedList<T>
    {
        // Aponta para o primeiro elemento da lista.
        private Node<T> _head;

        public void AddAtTheBeginning(T value)
        {
            Node<T> node = new Node<T>();
            // Adicionado o valor ao node.
            node.Value = value;
            // Apontando para o próximo elemento da lista.
            node.NextNode = _head;
            // Fazendo a cabaça apontar para o novo node que foi criado.
            _head = node;
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
