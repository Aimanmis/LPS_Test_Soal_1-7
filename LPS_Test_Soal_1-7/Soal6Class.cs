using System;
using System.Collections.Generic;

namespace LPS_Test_Soal_1_7
{
    public class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();

        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }

        // Method to clear the children of this node
        public void ClearChildren()
        {
            _children.Clear();
        }
    }

    public class Soal6Class
    {
        public void RunLargeObjectGraphExample()
        {
            var rootNode = new TreeNode();

            while (true)
            {
                // Create a new subtree of 10,000 nodes
                var newNode = new TreeNode();
                for (int i = 0; i < 10000; i++)
                {
                    var childNode = new TreeNode();
                    newNode.AddChild(childNode);
                }

                rootNode.AddChild(newNode);

                // Clear the children of rootNode periodically to release memory
                if (DateTime.Now.Second % 10 == 0) // Clear the children every 10 seconds (adjust as needed)
                {
                    Console.WriteLine("Clearing the children of rootNode...");
                    rootNode.ClearChildren();
                }
            }
        }
    }
}
