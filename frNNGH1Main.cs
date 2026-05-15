using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A04NNGHHandpan
{
    public partial class frNNGH1Main : Form
    {
        /// <summary>
        /// HÀM THIẾT LẬP CỦA FR MAIN = constructor của form chính
        /// </summary>
        public frNNGH1Main()
        {
            InitializeComponent();
        } //constructor

        /// <summary>
        /// THỦ TỤC NHẢY ĐỒNG HỒ => NHẢY ĐỒNG HỒ TRÊN DÒNG TRẠNG THÁI BÊN PHẢI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "Hôm nay là: " + DateTime.Now.ToShortDateString() + " Bây giờ là: " + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// THỦ TỤC GỌI FORM QUẢN LÝ ÂM THANH DÙNG WMP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frNNGH2WMP fr = new frNNGH2WMP();
            fr.ShowDialog();
        }// gọi WPM để quản lý âm thanh
        private void quảnLýÂmThanhDùngWMPToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frNNGH2WMP fr = new frNNGH2WMP();
            fr.ShowDialog();
        }// Crtl + M

        /// <summary>
        /// THỦ TỤC THOÁT CHƯƠNG TRÌNH => HIỆN HỘP THOẠI XÁC NHẬN THOÁT CHƯƠNG TRÌNH, NẾU NGƯỜI DÙNG CHỌN YES => THOÁT CHƯƠNG TRÌNH, NẾU NGƯỜI DÙNG CHỌN NO => Ở LẠI CHƯƠNG TRÌNH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn thoát chương trình (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }// HỆ THỐNG - ALT + F4

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn thoát chương trình (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }// CONTEXTMENUSTRIP - THOÁT CHƯƠNG TRÌNH

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn thoát chương trình (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }// TOOLSTRIP - CLOSE

        /// <summary>
        /// QUẢN LÝ ÂM THANH DÙNG IRRKLANG => GỌI FORM QUẢN LÝ ÂM THANH DÙNG IRRKLANG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quảnLýÂmThanhDùngIrrKLangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frNNGH3irrKLang fr = new frNNGH3irrKLang();
            fr.ShowDialog();
        }//irrKlang
    }//class
}//namespace
