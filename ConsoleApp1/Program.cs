using System;

namespace HeightBalancedBinaryTree
{
    class Program
    {
        public static bool isBalanced = true;

        static void Main(string[] args)
        {
            Node exercise = new Node(1);
            exercise.left = new Node(2);
            //exercise.right = new Node(3);
            exercise.left.left = new Node(4);
            //exercise.left.left.left = new Node(5);

            Console.WriteLine(CountHeight((exercise)));
            Console.WriteLine("isBalanced: ");
            Console.WriteLine(isBalanced);
            Console.ReadLine();
        }


        public static int CountHeight(Node node)
        {
            if (node == null) return 0;

            var heightLeft = 1 + CountHeight(node.left);
            var heightRight= 1 + CountHeight(node.right);

            var subtraction = heightLeft - heightRight;
            if (subtraction < 0)
            {
                subtraction = (subtraction * -1);
            }

            if (subtraction > 1)
            {
                isBalanced = false;
            }

            if (heightLeft >= heightRight)
            {
                return heightLeft;
            }
            else
            {
                return heightRight;
            }
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
