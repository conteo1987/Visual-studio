using System.Collections;
using System.Collections.Generic;

namespace Custom_List.Models
{
    public interface IMyList<T> : IEnumerable<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        T Max();

        T Min();

        void Sort();

    }
}
