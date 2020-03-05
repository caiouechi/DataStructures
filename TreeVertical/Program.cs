using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace TreeVertical
{
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

    class Program
    {
        static Dictionary<string,int> indexes = new Dictionary<string,int>();

        static void Main(string[] args)
        {
            Node root = new Node("A");
            root.left = new Node("B");
            root.right = new Node("C");
            root.left.left = new Node("D");
            root.left.right = new Node("E");
            root.right.left = new Node("F");
            root.right.right = new Node("G");

            ReadTree(root, 0);

            foreach(KeyValuePair<string,int> item in indexes){
            //    Console.WriteLine(item.Key + item.Value);
             }

            var keysGrouped = indexes.OrderBy(p => p.Key).GroupBy(p => p.Value).ToList();
            foreach (var item in keysGrouped)
            {
                var asdf = item.Count();
                foreach (var itemsub in item)
                {
                    Console.WriteLine(itemsub);
                }
            }
            
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public static void ReadTree(Node tree, int rootDistance){

                if(tree == null){
                return;
                }

            indexes.Add((string)tree.data, rootDistance);
            //Console.WriteLine("Value" + tree.data +" Distance: " + rootDistance);

            ReadTree(tree.left, rootDistance - 1);
            ReadTree(tree.right, rootDistance + 1);
        }

    }
}
