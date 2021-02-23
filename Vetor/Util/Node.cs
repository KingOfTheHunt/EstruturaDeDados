namespace EstruturaDeDados.Util
{
    // Representa um nó da listaa
    public class Node<T>
    {
        // O valor do nó
        public T Value { get; set; }
        // Referência para o próximo nó da da lista.
        public Node<T> NextNode { get; set; }
    }
}
