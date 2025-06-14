using System.Collections;

namespace Algorithms_CSharp.Collections;

public class SinglyLinkedList<T> : IEnumerable<T> where T : IComparable<T>
{
    internal ListNode<T>? _head;
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

    public ListNode<T>? GetMidElem(ListNode<T>? head)
    {
        if (head == null) return null;

        ListNode<T>? slow = head;
        ListNode<T>? fast = head;
        ListNode<T>? prev = null;

        while (fast != null && fast.Next != null)
        {
            prev = slow;
            slow = slow!.Next;
            fast = fast.Next.Next;
        }

        // For even-sized lists, return the first of the two middle nodes
        return (fast == null) ? prev : slow;
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
    public void MergeSort()
    {
        _head = MergeSort(_head);
    }

    private ListNode<T>? MergeSort(ListNode<T>? head)
    {
        if (head == null || head.Next == null)
            return head;

        var middle = GetMidElem(head);
        var nextToMiddle = middle?.Next;
        if (middle != null)
            middle.Next = null;

        var left = MergeSort(head);
        var right = MergeSort(nextToMiddle);

        return SortedMerge(left, right);
    }

    private ListNode<T>? SortedMerge(ListNode<T>? a, ListNode<T>? b)
    {
        if (a == null)
            return b;
        if (b == null)
            return a;

        if (Comparer<T>.Default.Compare(a.Value, b.Value) <= 0)
        {
            a.Next = SortedMerge(a.Next, b);
            return a;
        }
        else
        {
            b.Next = SortedMerge(a, b.Next);
            return b;
        }
    }

    public void InsertionSort()
    {
        if (_head == null || _head.Next == null)
            return;

        var dummy = new ListNode<T>(default!);
        dummy.Next = _head;

        var curr = _head;
        while (curr != null && curr.Next != null)
        {
            if (curr.Next.Value.CompareTo(curr.Value) < 0)
            {
                var toInsert = curr.Next;
                curr.Next = toInsert.Next;

                var pos = dummy;
                while (pos.Next != null && pos.Next.Value.CompareTo(toInsert.Value) < 0)
                {
                    pos = pos.Next;
                }
                toInsert.Next = pos.Next;
                pos.Next = toInsert;
            }
            else
            {
                curr = curr.Next;
            }
        }

        _head = dummy.Next;
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