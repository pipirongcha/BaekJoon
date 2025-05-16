using System.Text;
using System.Collections.Generic;

namespace No._1991
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(sr.ReadLine());
            Dictionary<string,TreeNode<string>> dict = new Dictionary<string,TreeNode<string>>();
            Tree<string> tree = new Tree<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine().Split();
                string parentVal = input[0];
                string leftVal = input[1];
                string rightVal = input[2];

                if(!dict.ContainsKey(parentVal))
                {
                    dict[parentVal] = new TreeNode<string>(parentVal);
                }
                TreeNode<string> parent = dict[parentVal];
                if (i == 0)
                {
                    tree.Root = parent;
                }
                if (leftVal != ".")
                {
                    if (!dict.ContainsKey(leftVal))
                    {
                        dict[leftVal] = new TreeNode<string>(leftVal);
                    }
                    parent.Left = dict[leftVal];
                }
                if (rightVal != ".")
                {
                    if (!dict.ContainsKey(rightVal))
                    {
                        dict[rightVal] = new TreeNode<string>(rightVal);
                    }
                    parent.Right = dict[rightVal];
                }
            }

            PreOrder();
            Write();
            InOrder(tree.Root);
            Write();
            PostOrder(tree.Root);
            Write();

            sw.Flush();

            void PreOrder()
            {
                Stack<TreeNode<string>> stack = new Stack<TreeNode<string>>();
                stack.Push(tree.Root);
                while (stack.Count > 0)
                {
                    TreeNode<string> tmp = stack.Pop();
                    sb.Append(tmp.Val);
                    if (tmp.Right != null)
                    {
                        stack.Push(tmp.Right);
                    }
                    if (tmp.Left != null)  
                    {
                        stack.Push(tmp.Left);
                    }
                }
            }

            void InOrder(TreeNode<string> node)
            {
                if(node == null)
                {
                    return;
                }
                
                InOrder(node.Left);
                sb.Append(node.Val);
                InOrder(node.Right);
            }

            void PostOrder(TreeNode<string> node)
            {
                if(node == null)
                {
                    return;
                }

                PostOrder(node.Left);
                PostOrder(node.Right);
                sb.Append(node.Val);

      
            }

            void Write()
            {
                sw.WriteLine(sb.ToString());
                sb.Clear();
            }

        }


    }

    public class TreeNode<T>
    {
        public T Val;
        public TreeNode<T> Left;
        public TreeNode<T> Right;

        public TreeNode(T val)
        {
            this.Val = val;
            this.Left = null;
            this.Right = null;
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root;

    }

    
}
