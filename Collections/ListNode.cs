namespace Algorithms_CSharp.Collections;

public class ListNode<T>
{
    public T Value { get; set; }
    public ListNode<T>? Next { get; internal set; } = default;

    public ListNode(T value, ListNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }
}