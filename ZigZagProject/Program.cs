using System;
using System.Collections;

namespace ZigZagProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Node exercise = new Node("A");
            exercise.left = new Node("B");
            exercise.right = new Node("C");
            exercise.left.left = new Node("D");
            exercise.left.right = new Node("E");
            exercise.right.left = new Node("F");
            exercise.right.right = new Node("G");
            exercise.right.right.left = new Node("N");
            exercise.right.right.right = new Node("O");
            exercise.right.right.right.left = new Node("X");
            exercise.right.right.right.right = new Node("A");

            PrintZigZag(exercise);

            Console.ReadKey();
        }

        public static void PrintZigZag(Node node)
        {
            Console.WriteLine("ZIGZAG!");

            if (node == null) return;

            bool zigZag = true;
            Queue mainQueue = new Queue();
            Queue auxQueue = new Queue();
            mainQueue.Enqueue(node);

            Stack auxStack = new Stack();

            while (mainQueue.Count > 0)
            {
                Node nodeTarget = (Node)mainQueue.Dequeue();
                auxStack.Push(nodeTarget);

                if (nodeTarget.left != null)
                {
                    auxQueue.Enqueue(nodeTarget.left);
                }

                if (nodeTarget.right != null)
                {
                    auxQueue.Enqueue(nodeTarget.right);
                }

                if (zigZag)
                {
                    Console.WriteLine(nodeTarget.data);
                }

                if (mainQueue.Count == 0)
                {
                    if (!zigZag)
                    {
                        while (auxStack.Count > 0)
                        {
                            Node objectPrint = (Node)auxStack.Pop();
                            Console.WriteLine(objectPrint.data.ToString());
                        }
                    }
                    zigZag = !zigZag;
                    mainQueue = (Queue)auxQueue.Clone();
                    auxQueue = new Queue();
                    auxStack = new Stack();
                }
            }
            Console.ReadKey();
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public object data;

        public Node(object data)
        {
            this.data = data;
        }
    }

}