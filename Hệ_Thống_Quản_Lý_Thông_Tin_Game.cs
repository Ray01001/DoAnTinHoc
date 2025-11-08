using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    public partial class Hệ_Thống_Quản_Lý_Thông_Tin_Game : Form
    {
        private BST gameTree = new BST();
        private FileHandler fileHandler = new FileHandler("games.txt");
        public Hệ_Thống_Quản_Lý_Thông_Tin_Game()
        {
            InitializeComponent();
        }
        private void Hệ_Thống_Quản_Lý_Thông_Tin_Game_Load(object sender, EventArgs e)
        {
            //CauHinhDataGridView();

            var danhSachGames = fileHandler.LoadFromFile();
            foreach (var g in danhSachGames)
            {
                gameTree.Insert(g);
            }
            HienThiDanhSach();
        }
        //private void CauHinhDataGridView()
        //{
        //    if (dgvGames.Columns.Count == 0) 
        //    {
        //        dgvGames.AutoGenerateColumns = false;
        //        dgvGames.Columns.Add("ID", "ID");
        //        dgvGames.Columns.Add("Ten", "TenGame");
        //        dgvGames.Columns.Add("TheLoai", "The Loai");
        //        dgvGames.Columns.Add("MoTa", "Mo Ta");
        //    }
        //    dgvGames.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
        //    dgvGames.MultiSelect = false;
        //}
        private void HienThiDanhSach()
        {
            dgvGames.Rows.Clear();
            var games = gameTree.InOrderTraversal();
            foreach (var game in games)
            {
                dgvGames.Rows.Add(game.ID, game.Ten, game.TheLoai, game.MoTa);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID không được để trống.");
                return;
            }
            var existed = gameTree.SearchByID(id);
            if (existed != null)
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.");
                return;
            }

            var game = new Game
            {
                ID = id,
                Ten = txtTen.Text.Trim(),
                TheLoai = txtTheLoai.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };
            gameTree.Insert(game);
            fileHandler.SaveToFile(gameTree.InOrderTraversal());
            HienThiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           string id = txtID.Text;
            Game game = gameTree.SearchByID(id);
            if (game != null)
            {
                game.Ten = txtTen.Text;
                game.TheLoai = txtTheLoai.Text;
                game.MoTa = txtMoTa.Text;
                fileHandler.SaveToFile(gameTree.InOrderTraversal());
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Game với ID này không tồn tại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            gameTree.Delete(id);
            fileHandler.SaveToFile(gameTree.InOrderTraversal());
            HienThiDanhSach();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            Game game = gameTree.SearchByID(id);
            if (game != null)
            {
                MessageBox.Show($"Tìm thấy game:\nID: {game.ID}\nTên: {game.Ten}\nThể Loại: {game.TheLoai}\nMô Tả: {game.MoTa}");
            }
            else
            {
                MessageBox.Show("Game với ID này không tồn tại.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
