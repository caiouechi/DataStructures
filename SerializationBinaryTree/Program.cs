
using System;
using System.Collections.Generic;

namespace SerializationBinaryTree
{
    public class Node
    {
        public Node left;
        public Node right;
        public string data;
        public Node(string value)
        {
            this.data = value;

        }

        public Node()
        {

        }
    }

    class Program
    {
        public static Node exercise;
        public static Queue<string> nodesSerialized = new Queue<string>();


        static void Main(string[] args)
        {
            Node root = new Node("A");
            root.left = new Node("B");
            root.right = new Node("C");
            root.left.left = new Node("D");
            root.left.right = new Node("E");
            root.right.left = new Node("F");
            root.right.right = new Node("G");

            exercise = root;

            SerializeTree(exercise);
            //while (nodesSerialized.Count > 0)
            //{
            //    //var itemSerialized = (string)nodesSerialized.Dequeue();
            //    //Console.Write(itemSerialized + " ");
            //}
            Console.WriteLine("");

      
            Node treeDeserialized = new Node();
            DeserializeTree(ref treeDeserialized, nodesSerialized);

            SerializeTree(treeDeserialized);

            while (nodesSerialized.Count > 0 )
            {
                var itemSerialized = (string)nodesSerialized.Dequeue();
                Console.Write(itemSerialized + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }


        public static void SerializeTree(Node tree)
        {
            if (tree == null)
            {
                nodesSerialized.Enqueue("-1");
                return;
            }
            
            nodesSerialized.Enqueue(tree.data);

            SerializeTree(tree.left);
            SerializeTree(tree.right);
        }

        public static void DeserializeTree(ref Node tree, Queue<string> treeSerialized)
        {
            var itemSerialized = (string)nodesSerialized.Dequeue();

            if (itemSerialized == "-1")
            {
                return;
            }
            tree = new Node(itemSerialized);
            DeserializeTree(ref tree.left, treeSerialized);
            DeserializeTree(ref tree.right, treeSerialized);
        }
    }
}
