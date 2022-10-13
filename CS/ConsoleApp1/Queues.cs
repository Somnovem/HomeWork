using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PriorityQueue<K,T>
    {
        public int Capacity { get; set; } = 10;
        SortedList<K, T> queue = new SortedList<K, T>();
        public bool Add(K prio, T value)
        {
            if (queue.Count < Capacity)
            {
                queue.Add(prio, value);
                return true;
            }
            return false;
        }
        public T Remove(K ind)
        {
            if (!queue.ContainsKey(ind))
            {
                throw new ArgumentOutOfRangeException();
            }
            T temp = queue[ind];
            queue.Remove(ind);
            return temp;
        }
        public int Count()
        {
            return queue.Count;
        }
        public T ElementAt(K key)
        {
            if (queue.ContainsKey(key))
            {
                return queue[key];
            }
            throw new ArgumentOutOfRangeException();
        }
        public bool Contains(KeyValuePair<K, T> pair)
        {
        return queue.Contains(pair);
        }
        public bool ContainsKey(K key)
        {
        return queue.ContainsKey(key);
        }
        public bool ContainsValue(T value)
        {
            return queue.ContainsValue(value);
        }
        public KeyValuePair<K, T> First() { return queue.First(); }
        public KeyValuePair<K, T> Last() { return queue.Last(); }
        public void Clear()
        {
            if (queue.Count != 0)
            {
                queue.Clear();
            }
        }
        public int IndexOfKey(K key)
        {
            return queue.IndexOfKey(key);
        }
        public int IndexOfValue(T value)
        {
            return queue.IndexOfValue(value);
        }
        public void Reverse()
        {
            if (queue.Count > 1)
            {
                queue.Reverse();
            }
        }
    }
    internal class CircledQueue<T> : Queue<T>
    {
        public void Circle()
        {
            this.Enqueue(this.Dequeue());
        }
    }

}
