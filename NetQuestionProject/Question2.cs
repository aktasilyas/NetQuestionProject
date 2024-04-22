using System;
using System.Collections;
using System.Collections.Generic;

public class Question2<T> : IList<T>, ICollection<T>, IEnumerable<T>
{
    private List<T> items = new List<T>();

    // Implementing IList<T> methods
    public T this[int index]
    {
        get => items[index];
        set => items[index] = value;
    }

    public int Count => items.Count;
    public bool IsReadOnly => false;

    public void Add(T item) => items.Add(item);
    public void Clear() => items.Clear();
    public bool Contains(T item) => items.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
    public int IndexOf(T item) => items.IndexOf(item);
    public void Insert(int index, T item) => items.Insert(index, item);
    public bool Remove(T item) => items.Remove(item);
    public void RemoveAt(int index) => items.RemoveAt(index);

    // Implementing ICollection<T> methods
    void ICollection<T>.Add(T item) => Add(item);
    bool ICollection<T>.Remove(T item) => Remove(item);
    void ICollection<T>.Clear() => Clear();
    bool ICollection<T>.Contains(T item) => Contains(item);
    void ICollection<T>.CopyTo(T[] array, int arrayIndex) => CopyTo(array, arrayIndex);
    int ICollection<T>.Count => Count;
    bool ICollection<T>.IsReadOnly => IsReadOnly;

    // Implementing IEnumerable<T> method
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
