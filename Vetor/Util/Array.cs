using System;
using System.Text;

namespace EstruturaDeDados.Util
{
    public class Array<T> where T : class
    {
        private T[] _ts = new T[10];
        private int _count = 0;

        // Adicionar um elemento ao vetor.
        public void Add(T t)
        {
            MoreSpace();

            _ts[_count] = t;
            _count++;
        }

        // Adiciona mais de um elemento de uma só vez ao vetor.
        public void AddRange(params T[] ts)
        {
            MoreSpace();

            for (int i = 0; i < ts.Length; i++)
            {
                _ts[_count] = ts[i];
                _count++;
            }
        }

        // Adiciona um elemento a uma determinada posição.
        public void Insert(int position, T t)
        {
            MoreSpace();

            if (ValidPosition(position) == false)
            {
                throw new ArgumentException("A posição informada não é válida.");
            }

            for (int i = _count - 1; i >= position; i--)
            {
                _ts[i + 1] = _ts[i];
            }

            _ts[position] = t;
            _count++;
        }

        // Remove um elemento do vetor
        public void Remove(int position)
        {
            if (ValidPosition(position) == false)
            {
                throw new ArgumentException("A posição informada não é válida.");
            }

            for (int i = position; i < _count - 1; i++)
            {
                _ts[i] = _ts[i + 1];
            }

            _count--;
        }

        public void RemoveAll(T t)
        {
            while (IndexOf(t) != -1)
            {
                int position = IndexOf(t);
                Remove(position);
            }
        }

        public int IndexOf(T t)
        {
            for (int i = 0; i < _ts.Length; i++)
            {
                if (_ts[i] != null && _ts[i].Equals(t))
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(T t)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_ts[i] != null && _ts[i].Equals(t))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            _ts = new T[10];
            _count = 0;
        }

        // Verifica se há um elemento igual no vetor.
        public bool Contains(T t)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_ts[i] != null && _ts[i].Equals(t))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            for (int i = 0; i < _count; i++)
            {
                sb.Append(_ts[i] + " ");
            }
            sb.Append("]");

            return sb.ToString();
        }

        private void MoreSpace()
        {
            if (_count == _ts.Length)
            {
                T[] newArray = new T[_ts.Length * 2];

                for (int i = 0; i < _ts.Length; i++)
                {
                    newArray[i] = _ts[i];
                }

                _ts = newArray;
            }
        }

        private bool ValidPosition(int position)
        {
            return position >= 0 && position < _count;
        }
    }
}
