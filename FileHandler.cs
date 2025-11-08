using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    internal class FileHandler
    {
        private readonly string path;
        public FileHandler(string path = "games.txt")
        {
            this.path = path;
        }
        public void SaveToFile(List<Game> games)
        {
            try
            {
                var lines = games.Select(g => g.ToString());
                File.WriteAllLines(path, lines);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
            }
        }
        public List<Game> LoadFromFile()
        {
            var games = new List<Game>();

            // Nếu file chưa tồn tại thì tạo file rỗng
            if (!File.Exists(path))
            {
                File.Create(path).Close(); // tạo file trống
                return games;              // trả về danh sách rỗng
            }

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    games.Add(new Game
                    {
                        ID = parts[0],
                        Ten = parts[1],
                        TheLoai = parts[2],
                        MoTa = parts[3]
                    });
                }
            }
            return games;
        }
    }
}
