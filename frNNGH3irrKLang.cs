using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace A04NNGHHandpan
{
    public partial class frNNGH3irrKLang : Form
    {
        //Khai báo biến toàn cục thuộc đối tượng File âm thanh của irrKLang 
        string audiopath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\AudioFiles\\";
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
        //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần
        //để lấy thư mục cha sử dụng System.IO.Path.GetDirectoryName(Application.StartupPath)

        //KHAI BÁO CÁC BIẾN TOÀN CỤC 

        ISoundEngine fn = new ISoundEngine();

        public frNNGH3irrKLang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PLAY SOUND 2D DÙNG irrKLang 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            // Tạo sẵn 1 biến chứa đường dẫn hoàn chỉnh
            string fullPath = audiopath + "Documentary.wav";

            // Bắt hệ thống dò tìm file vật lý trên ổ cứng trước khi phát
            if (System.IO.File.Exists(fullPath))
            {
                fn.SoundVolume = 1.0f;
                fn.Play2D(fullPath, true);
                MessageBox.Show("TÌM THẤY FILE! Đã ra lệnh Play âm thanh.");
            }
            else
            {
                // In ra màn hình cái đường dẫn bị sai để mình tự soi
                MessageBox.Show("LỖI RỒI: Không tìm thấy nhạc ở đường dẫn này:\n" + fullPath);
            }
        }//button Play Sound
    }//class
}//namespace
