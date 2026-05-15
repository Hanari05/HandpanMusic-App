using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; //Âm thanh sử dụng Loa trong = có sẵn của PC
using AxWMPLib; //Âm thanh sử dụng Loa Ngoài = lắp vào PC = Aux...
using System.IO; //để lấy đường dẫn của File âm thanh 

namespace A04NNGHHandpan
{
    public partial class frNNGH2WMP : Form
    {
        string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\AudioFiles\\"; //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
                                                                                                                     //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần
        /// <summary>
        /// HÀM THIẾT LẬP CỦA FR MAIN = constructor của form chính
        /// </summary>
        public frNNGH2WMP()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FORM LOAD = TỰ CHẠY THỦ TỤC NÀY, MỖI KHI FORM NÀY ĐƯỢC LOAD [MỞ] LÊN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frNNGH2WMP_Load(object sender, EventArgs e)
        {
            try
            {
                this.aUDIOFILESTableAdapter.Fill(this.a04NNGHHandpanDataSet.AUDIOFILES);
            }
            catch (System.Exception ex) { MessageBox.Show("Lỗi nạp dữ lệu các files âm thanh " + ex.Message); }
        }

        /// <summary>
        /// CLOSE FORM NÀY => MH CHÍNH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn đóng màn hình này. về màn hình chính (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }//close

        /// <summary>
        /// THOÁT APP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn thoát chương trình (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }//exit

        /// <summary>
        /// LẬP TRÌNH THAO TÁC XỬ LÝ ÂM THANH 
        /// </summary>
        //Play = CHẠY FILE AUDIO FILES
        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.play(); //chạy (play) file âm thanh hiện tại trên WMP
        }
        //Stop = DỪNG AUDIO FILES ĐANG CHẠY
        private void btnStop_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.stop();// Dừng (Stop) audio file hiện đang play trên WMP
        }
        //Pause = TẠM DỪNG AUDIO FILES ĐANG CHẠY
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause(); // tạm dừng (pause) audio file hiện đang play trên WMP
        }
        //Faster = CHẠY AUDIO FILES NHANH HƠN (do tìm)
        private void btnFast_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.fastForward();
        }
        //CHẠY AUDIO FILES CHẬM HƠN (do tìm)
        private void btnSlow_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.fastReverse();
        }
        //VỀ TRACK ĐẦU TIÊN
        private void btnPFirst_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = 0;
        }
        //CHẠY TRACK KẾ TRƯỚC; NẾU TRACK ĐẦU TIÊN => VỀ TRACK CUỐI
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex > 0) listBoxAuFile.SelectedIndex--;
            //Nếu chưa phải là Track ĐẦU ( > 0)  thì GIẢM vị trí Track XUỐNG 1 (--) đến Track kế TRƯỚC
            else listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1; //nếu đang là Track ĐẦU (0) thì chuyển XUỐNG Track CUỐI CÙNG (vi trí vị trí cuối: count -1)        
        }
        //CHẠY TRACK KẾ TIẾP; NẾU TRACK CUỐI => VỀ TRACK ĐẦU
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex < listBoxAuFile.Items.Count - 1)
                listBoxAuFile.SelectedIndex++; //Nếu chưa phải là Track cuối ( < vị trí cuối: count -1)  thì tăng vị trí Track lên 1(++) đến Track kế tiếp
            else listBoxAuFile.SelectedIndex = 0; //nếu đang là Track cuối (count - 1) thì chuyển về Track đầu tiên(vi trí 0)            
        }
        //XUỐNG TRACK ĐẦU CUỐI CÙNG
        private void btnLast_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1;
        }

        /// <summary>
        /// LẬP TRÌNH THAO TÁC QUẢN LÝ ÂM THANH
        /// </summary>
        /// 

        static DialogResult ch = DialogResult.No; //BIẾN TOÀN CỤC Giữ nút lệnh NSD đã chọn; 
        // khi Chọn file âm thanh dùng OpenFileDialog: Y = đồng ý chọn file, N = ko đồng ý(sẽ chọn lại, hoặc ko chọn)
        //bắt buộc static = Sau khi ra khỏi thủ tục vẫn giữ lại giá trị KO bị hủy vùng nhó
        /// <summary>
        /// NẠP THÊM FILES ÂM THANH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            //B1:Cho || cấm các nút lệnh khác và một số textbox liên quan thông tin file âm thanh mà NSD tự nhập (mã số, mô tả) 
            txtMaso.Enabled = !txtMaso.Enabled;
            txtDesc.Enabled = !txtDesc.Enabled;
            btnModify.Enabled = !btnModify.Enabled;
            btnRecord.Enabled = !btnRecord.Enabled;
            btnDelete.Enabled = !btnDelete.Enabled;

            //B2: ĐỔI NHÃN (.TEXT) CỦA NÚT LỆNH : "Nạp..." <-> "Lưu..."
            if (btnNew.Text == "Nạp file mới")
            //bắt đầu nập file âm thanh = NSD chọn file & nập thông tin ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
            {//Mở OpenFilesDialog lên cho NSD chọn file âm thanh / PC
                ch = openFileDialog1.ShowDialog();
                if (ch == DialogResult.OK)
                {
                    //biến toàn cục ch đã khai báo phía trên, giữ lại nút lệnh (Y|N) mà NSD đã chọn để xử lý trong ...else..  
                    txtMaso.Text = "Quý vị phải nhập mã số file vào đây";
                    txtDesc.Text = ""; // Xóa thống để NSD nhập mlo6 tả mới
                    btnNew.Text = "Lưu file âm thanh"; //Đổi nhãn (.Text) thahh2 "Lưu...": tự nhập

                    //BS1: Nhập thông tin Size, Ext và Length 
                    string filePath = openFileDialog1.FileName;
                    txtname.Text = Path.GetFileName(filePath);
                    txtExt.Text = Path.GetExtension(filePath);

                    FileInfo fileInfo = new FileInfo(filePath);
                    long sizeInKB = fileInfo.Length / 1024;
                    txtSize.Text = sizeInKB.ToString();

                    var mediaInfo = axWMP.newMedia(filePath);
                    txtLeng.Text = ((int)mediaInfo.duration).ToString();
                }
            }
            else//Sau khi NSD chọn file & nhập thông tin xong => Lưu file âm thanh vào thư mục App\AudioFiles và cập nhật thông tin file âm thanh vào DB
            {//B3: NẠP FILE ÂM THANH VÀO APP = GỒM 2 BƯỚC CƠ BẢN = COPY FILE ÂM THANH VÀO THƯ MỤC CỦA APP(AudioFiles) +Update THÔNG TIN FILE ÂM THANH VÀO DB
                if (ch == DialogResult.OK)//NSD đã đồng ý nạp file âm thanh đã chọn từ OpenFileDialog
                {
                    string tenfile = System.IO.Path.GetFileName(openFileDialog1.FileName);//tên file âm thanh mà NSD đã chọn


                    //BS2: WMP nhả file ra để không bị lỗi "đang sử dụng" khi Copy - VẪN CHƯA CHẠY ĐƯỢC -> SỬA LẠI SAU
                    axWMP.Ctlcontrols.stop();
                    axWMP.URL = "";


                    //[1] COPY FILE ÂM THANH ĐÃ CHỌN VÀO THƯ MỤC ~\\AudioFiles
                    try
                    {
                        File.Copy(openFileDialog1.FileName, audiopath + tenfile, true);
                        //[1 TRONG 2 CÂU LỆNH QUANG TRỌNG] //openFileDialog1.FileName = Full path của file nguồn || System.IO.Path.GetFileName(...) lấy tên của path || true = chồng lên nêu trong thư mục đã có sẵn file
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi copy file âm thanh:" + ex.Message); }

                    //[2] NẠP THÔNG TIN CỦA FILE ÂM THANH ĐÃ CHỌN VÀO DATABASE SQL
                    if (txtMaso.Text != "" && txtMaso.Text != "Quý vị phải nhập mã số file vào đây")
                    //NSD bắt buộc nhập mã số file âm thanh thì mới lưu được.
                    {
                        try
                        {// BS3: Lấy dữ liệu thực tế từ các ô Textbox để đưa vào câu lệnh Inser
                            int kichThuoc = int.Parse(txtSize.Text);
                            int chieuDai = int.Parse(txtLeng.Text);
                            string phanMoRong = txtExt.Text;

                            aUDIOFILESTableAdapter.Insert(txtMaso.Text.Trim(), audiopath + tenfile, tenfile, kichThuoc, phanMoRong, chieuDai, txtDesc.Text);
                            //NẠP THÔNG TIN FILE ÂM THANH VÀO DB [1 TRONG 2 CÂU LỆNH QUANG TRỌNG]
                        }
                        catch (System.Exception ex)
                        { MessageBox.Show("Có lỗi khi nạp thông tin file âm thanh vào DB: " + ex.Message); }
                    }
                    else MessageBox.Show("Không được để trống mã file");

                    //B4: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP = COPY xuống TỪ trên FrWMPManagement_Load(..)
                    try
                    {
                        this.aUDIOFILESTableAdapter.Fill(this.a04NNGHHandpanDataSet.AUDIOFILES);
                    }
                    catch (System.Exception ex) { MessageBox.Show("Lỗi nạp dữ lệu các files âm thanh " + ex.Message); }

                    btnNew.Text = "Nạp file mới";
                    //Trả lại nhãn ban đầu ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
                }//NSD OK              
            }//Lưu file

        }
        /// <summary>
        /// THAY ĐỔI THÔNG TIN FILE ÂM THANH // SỬA THÔNG TIN FILE ÂM THANH ĐÃ CÓ TRONG DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            //B1:Cho || cấm các nút lệnh các khác và textbox mô tả tin file âm thanh (không sửa được các thông khác)
            txtDesc.Enabled = !txtDesc.Enabled;
            btnNew.Enabled = !btnNew.Enabled;
            btnRecord.Enabled = !btnRecord.Enabled;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            btnFast.Enabled = !btnFast.Enabled;
            btnSlow.Enabled = !btnSlow.Enabled;
            btnFirst.Enabled = !btnFirst.Enabled;
            btnLast.Enabled = !btnLast.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            btnPre.Enabled = !btnPre.Enabled;
            //B2: ĐỔI NHÃN (.TEXT) CỦA NÚT LỆNH : "Sửa..." <-> "Lưu..."
            if (btnModify.Text == "Sửa thông tin file")
            //bắt đầu Sửa thông tin file âm thanh trong các TextBox ["Sửa thông tin files" copy từ Design sang, KHÔNG tự nhập]
            {//Thông báo nhắc NSD cách sủa thông tin
                MessageBox.Show("Quý vị sửa mô tả file trong TextBox Mô tả phía trên, Không sửa được các thông tin khác."); //thông báo hướng dẫn NSD cách sửa thông tin file            
                btnModify.Text = "Lưu sau sửa"; //Đổi nhãn (.Text) thành2 "Lưu...": tự nhập
            }
            else//Sau khi NSD sửa thông tin xong =>Lưu thông tin file âm thanh sau sửa vào DB
            {//B3: SỬA THÔNG TIN FILE ÂM THANH  + Update THÔNG TIN SỬA VÀO DB
                try
                {
                    aUDIOFILESTableAdapter.Update(txtDesc.Text, txtMaso.Text.Trim());
                    //Lưu THÔNG TIN FILE ÂM THANH sau Sửa VÀO DB [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi SỬA thông tin file âm thanh: " + ex.Message); }

                //B4: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP = COPY xuống TỪ trên FrWMPManagement_Load(..)
                 try
                    {
                        this.aUDIOFILESTableAdapter.Fill(this.a04NNGHHandpanDataSet.AUDIOFILES);
                    }
                    catch (System.Exception ex) { MessageBox.Show("Lỗi nạp dữ lệu các files âm thanh " + ex.Message); 
                }
                //B5: Đổi nhãn thành ban đầu
                btnModify.Text = "Sửa thông tin file";
                //Trả lại nhãn ban đầu ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]                
            }//else Lưu thông tin file vào DB

        }

        /// <summary>
        /// XÓA FILE ÂM THANH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Thiệt xóa file âm thanh: " + txtMaso.Text.Trim() + " _ " + txtname.Text.Trim() + " không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //B2: XÓA Khi NSD Y
            if (ch == DialogResult.Yes)//NSD đồng ý Xóa
            {
                try
                {
                    aUDIOFILESTableAdapter.Delete(txtMaso.Text.Trim());//XÓA FILE ÂM THANH [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi XÓA file âm thanh: " + ex.Message); }
                //B3: Tải các file sau xóa lên ListBox = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.a04NNGHHandpanDataSet.AUDIOFILES);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi nạp dữ lệu các files âm thanh " + ex.Message); }
            }//If NSD Y

        }//private void btnDelete_Click(object sender, EventArgs e)
}//class
}//namespace
