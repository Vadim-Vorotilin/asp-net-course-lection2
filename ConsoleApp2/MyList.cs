using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class MyList<T> : IEnumerable, IEnumerator, IEnumerable<T>, IEnumerator<T>
    {
        private T[] _values;
        private int _count = 0;
        private int _current = -1;
        
        public MyList()
        {
            _values = new T[4];
        }

        public MyList(int capacity)
        {
            _values = new T[capacity];
        }

        public int Count => _count;

        public void Add(T value)
        {
            if (_count >= _values.Length)
            {
                Array.Resize(ref _values, _values.Length * 2);
            }

            _values[_count] = value;

            ++_count;
        }
        
        public IEnumerator<T> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;

        public bool MoveNext()
        {
            ++_current;

            return _current < _count;
        }

        public void Reset()
        {
            _current = -1;
        }

        public T Current => _values[_current];

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}