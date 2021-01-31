using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UserCollection.UserCollection
{
    class MyCollection <T> : IEnumerable<T>
    {
        private readonly List<T> _list;

        public MyCollection(params T[] content)
        {
            _list = content.ToList();
        }

        public void Add(T item)
        {// Ограничение по заданию, связанное с типом добавляемого элемента не актуально, т.к. используется generic-коллекция
            _list.Add(item);
        }

        public void Remove(T item)
        {
            if (_list.Count > 5) _list.Remove(item);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(_list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class MyEnumerator<T> : IEnumerator<T>
    {
        private readonly List<T> _list;
        private int _currentPosition = -1;
        public MyEnumerator(List<T> list)
        {
            _list = list;
        }
        public bool MoveNext()
        {
            try
            {
               T t = _list[++_currentPosition];
               return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        public T Current => _list[_currentPosition];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _list.Clear();
        }
    }
}
