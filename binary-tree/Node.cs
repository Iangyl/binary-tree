using System;

namespace binary_tree
{
    class Node<T> where T : IComparable //інтерфейс для порівнювання
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public int CompareTo(object obj)
        {
            if(obj is Node<T> item)
            {
               return Data.CompareTo(obj);
            }
            else
            {
                throw new Exception("Error! Type mismatch.");
            }
        }
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                    
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
    }
}
