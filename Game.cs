using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    internal class Game
    {
        public string ID { get; set; }
        public string Ten { get; set; }
        public string TheLoai { get; set; }
        public string MoTa { get; set; }

        public override string ToString()
        {
            return $"{ID}|{Ten}|{TheLoai}|{MoTa}";
        }
    }
}
