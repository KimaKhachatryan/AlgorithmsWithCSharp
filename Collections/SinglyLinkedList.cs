using System.Collections;

namespace Algorithms_CSharp.Collections;

public class SinglyLinkedList<T> : IEnumerable<T>
{
    private ListNode<T>? _head;
    private long _count;

    public long Count => _count;
    public ListNode<T>? Head => _head;

    public SinglyLinkedList()
    {
        _head = null;
        _count = 0;
    }

    public void AddFirst(T value)
    {
        _head = new ListNode<T>(value, _head);
        _count++;
    }

    public void AddLast(T value)
    {
        ListNode<T> newListNode = new ListNode<T>(value);
        if (_head == null)
        {
            _head = newListNode;
        }
        else
        {
            ListNode<T>? current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newListNode;
        }
        _count++;
    }

    public bool RemoveFirst()
    {
        if (_head == null)
            return false;

        _head = _head.Next;
        _count--;
        return true;
    }

    public ListNode<T>? Find(T value)
    {
        ListNode<T>? current = _head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
                return current;
            current = current.Next;
        }
        return null;
    }

    public void Clear()
    {
        _head = null;
        _count = 0;
    }

    public ListNode<T>? GetMidElem()
    {
        if (_head == null) return null;

        ListNode<T>? slow = _head;
        ListNode<T>? fast = _head;

        while (fast != null && fast.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }

    public bool HasCycle()
    {
        ListNode<T>? slow = _head;
        ListNode<T>? fast = _head;
        while (fast != null && fast.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;
            if (slow == fast)
                return true;
        }
        return false;
    }

    // HashSet-based cycle detection
    public bool HasCycleHashSet()
    {
        var visited = new HashSet<ListNode<T>>();
        var current = _head;
        while (current != null)
        {
            if (!visited.Add(current))
                return true;
            current = current.Next;
        }
        return false;
    }

    public void Reverse()
    {
        ListNode<T>? prev = null;
        ListNode<T>? current = _head;
        while (current != null)
        {
            var next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        _head = prev;
    }

    public IEnumerator<T> GetEnumerator()
    {
        ListNode<T>? current = _head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}