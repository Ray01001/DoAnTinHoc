using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    internal class BST
    {
        public Node Root;
        public BST()
        {
            Root = null;
        }
        public void Insert(Game game)
        {
            Root = Insert(Root, game);
        }
        private Node Insert(Node root, Game game)
        {
            if (root == null)
            {
                root = new Node(game);
                return root;
            }
            if (string.Compare(game.ID, root.Data.ID) < 0)
            {
                root.Left = Insert(root.Left, game);
            }
            else if (string.Compare(game.ID, root.Data.ID) > 0)
            {
                root.Right = Insert(root.Right, game);
            }
            return root;
        }

        public Game SearchByID(string id)
        {
            return SearchByID(Root, id);
        }

        private Game SearchByID(Node root, string id)
        {
            if (root == null)
            {
                return null;
            }
            if (root.Data.ID == id)
            {
                return root.Data;
            }
            if (string.Compare(id, root.Data.ID) < 0)
            {
                return SearchByID(root.Left, id);
            }
            else
            {
                return SearchByID(root.Right, id);
            }
        }
        public List<Game> InOrderTraversal()
        {
            List<Game> games = new List<Game>();
            InOrderTraversal(Root, games);
            return games;
        }

        private void InOrderTraversal(Node root, List<Game> result)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left, result);
                result.Add(root.Data);
                InOrderTraversal(root.Right, result);
            }
        }
        public void Delete(string id)
        {
            Root = DeleteNode(Root, id);
        }
        private Node DeleteNode(Node root, string id)
        {
            if (root == null) return null;

            int cmp = string.Compare(id, root.Data.ID, StringComparison.Ordinal);
            if (cmp < 0)
                root.Left = DeleteNode(root.Left, id);
            else if (cmp > 0)
                root.Right = DeleteNode(root.Right, id);
            else
            {
                // root là node cần xóa
                if (root.Left == null) return root.Right;
                if (root.Right == null) return root.Left;

                // có 2 con: tìm node nhỏ nhất bên phải (in-order successor)
                Node minRight = MinNode(root.Right);
                root.Data = minRight.Data;                       // copy dữ liệu
                root.Right = DeleteNode(root.Right, minRight.Data.ID); // xóa node kế nhiệm
            }
            return root;
        }

        private Node MinNode(Node node)
        {
            while (node.Left != null) node = node.Left;
            return node;
        }
    }
}
