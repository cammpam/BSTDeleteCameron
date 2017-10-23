using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTDeleteCameron
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree newTree = new BinaryTree();
            newTree.Add(newTree.Root, 5);
            newTree.Add(newTree.Root, 6);
            newTree.Add(newTree.Root, 4);
            newTree.Add(newTree.Root, 1);
            newTree.Add(newTree.Root, 2);
            newTree.Add(newTree.Root, 3);
            newTree.Add(newTree.Root, 7);
            newTree.Add(newTree.Root, 8);
            Console.WriteLine("Delete:");
            Console.WriteLine(newTree.Remove(newTree.Root, 5).Data);
            Console.WriteLine(newTree.Remove(newTree.Root, 4).Data);
            Console.WriteLine(newTree.Remove(newTree.Root, 7).Data);
            Console.WriteLine("New Tree:");
            newTree.Print(newTree.Root);
            Console.Read();
        }
    }
}
