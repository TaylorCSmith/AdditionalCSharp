using System;
using System.Collections.Generic;
using System.Text;

namespace Example_Tree_Implementation
{
    class TreeDefinition
    {
        public class TreeNode<T>
        {
            // value of the node
            private T value;

            public T Value { get => value; set => this.value = value; }

            // shows whether the node has a parent
            private bool hasParent;

            // contains the children of the node (zero or more)
            private List<TreeNode<T>> children;

            // constructs a tree node and passes in the value to be stored
            public TreeNode(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot insert a null value");
                }
                this.Value = value;
                this.children = new List<TreeNode<T>>();
            }

            // the number of a node's children
            public int ChildrenCount { get => this.children.Count; }

            // add's a child to the node, child: the child to be added 
            public void AddChild(TreeNode<T> child)
            {
                if (child == null)
                {
                    throw new ArgumentNullException("Cannot insert null value!");
                }

                if (child.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }

                // changes the value of has parent to true 
                child.hasParent = true;

                // add's a child to the children list
                this.children.Add(child);
            }

            // gets the child of the node at given index; index: the index of the desired child; return: the child on the given position
            public TreeNode<T> GetChild(int index)
            {
                return this.children[index];
            }


        }
            // Represents a tree data structure; T: the type of the avlues in the tree
            public class Tree<T>
            {
                // the root of the tree... 
                private TreeNode<T> root;

                // constructs the tree; value: the value of the node
                
                public Tree(T value)
                {
                    if (value == null )
                    {
                        throw new ArgumentNullException("Cannot insert a null value");
                    }

                    this.root = new TreeNode<T>(value); 
                }

                // constructs the tree; value: the value of the root node; children: the value of the root node
                public Tree(T value, params Tree<T>[] children) : this(value)
                {
                    foreach(Tree<T> child in children)
                    {
                        this.root.AddChild(child.root); 
                    }
                }

                // returns the root node or null if the tree is empty
                public TreeNode<T> Root { get => this.root; }

                // traverses and prints tree ni DFS manner; root: the root of the tree; spaces: the spaces used for representation of the parent-child relation
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

                // traverses and prints the tree in DFS manner
                public void TraverseDFS()
                {
                    this.PrintDFS(this.root, string.Empty);
                }
            }
    }
}
