using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    internal class Node
    {
        public Game Data;
        public Node Left;
        public Node Right;
        public Node(Game data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
