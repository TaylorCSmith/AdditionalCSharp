using System;
using System.Collections.Generic;

namespace Problem_1
{
    class OccTree
    {
        public class TreeNode<T>
        {
            private T value;
            private bool hasParent;
            private List<TreeNode<T>> children;

            public T Value { get => value; set => this.value = value; }
            public int ChildrenCount { get => this.children.Count; }

            public TreeNode(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot insert a null value");
                }
                this.Value = value;
                this.children = new List<TreeNode<T>>(); 
            }

            public void AddChild(TreeNode<T> child)
            {
                if (child == null)
                {
                    throw new ArgumentNullException("Cannot insert null value");
                }

                if (child.hasParent)
                {
                    throw new ArgumentException("This node already has a parent");
                }

                child.hasParent = true;
                this.children.Add(child);
            }

            public TreeNode<T> GetChild(int index)
            {
                return this.children[index];
            }
        }

        public class Tree<T>
        {
            private TreeNode<T> root;
            private int[] numOcc = new int[100]; 

            public TreeNode<T> Root { get => this.root; }
            public int[] NumOcc { get => numOcc; set => numOcc = value; }

            public Tree(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot insert a null value");
                }

                this.root = new TreeNode<T>(value); 
            }

            public Tree(T value, params Tree<T>[] children) : this(value)
            {
                foreach (Tree<T> child in children)
                {
                    this.root.AddChild(child.root);
                }
            }

            private void PrintDFS(TreeNode<T> root, string spaces)
            {
                if (this.root == null)
                    return;

                Console.WriteLine(spaces + root.Value);

                TreeNode<T> child = null;
                for (int i = 0; i < root.ChildrenCount; i++)
                {
                    child = root.GetChild(i);
                    PrintDFS(child, spaces + " ");
                }
            }
        }
    }
}
