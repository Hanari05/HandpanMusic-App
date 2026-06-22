namespace A04NNGHHandpan
{
    partial class frNNGH2WMP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frNNGH2WMP));
            this.lbTitle = new System.Windows.Forms.Label();
            this.gBAudioInfo04 = new System.Windows.Forms.GroupBox();
            this.lbLengs = new System.Windows.Forms.Label();
            this.lbSizeKB = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.aUDIOFILESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a04NNGHHandpanDataSet = new A04NNGHHandpan.A04NNGHHandpanDataSet();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtMaso = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbLeng = new System.Windows.Forms.Label();
            this.lbExt = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbMaso = new System.Windows.Forms.Label();
            this.listBoxAuFileInfo = new System.Windows.Forms.Label();
            this.listBoxAuFile = new System.Windows.Forms.ListBox();
            this.listBoxAuFileSelect = new System.Windows.Forms.Label();
            this.gBAudioTest04 = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.aUDIOFILESTableAdapter = new A04NNGHHandpan.A04NNGHHandpanDataSetTableAdapters.AUDIOFILESTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gBAudioInfo04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a04NNGHHandpanDataSet)).BeginInit();
            this.gBAudioTest04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTitle.Location = new System.Drawing.Point(27, 46);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(956, 29);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "[04 NNGH] QUẢN LÝ FILEs ÂM THANH DÙNG THƯ VIỆN WMP.dll CỦA MS. WINDOWS";
            // 
            // gBAudioInfo04
            // 
            this.gBAudioInfo04.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gBAudioInfo04.Controls.Add(this.lbLengs);
            this.gBAudioInfo04.Controls.Add(this.lbSizeKB);
            this.gBAudioInfo04.Controls.Add(this.txtDesc);
            this.gBAudioInfo04.Controls.Add(this.txtLeng);
            this.gBAudioInfo04.Controls.Add(this.txtExt);
            this.gBAudioInfo04.Controls.Add(this.txtSize);
            this.gBAudioInfo04.Controls.Add(this.txtpath);
            this.gBAudioInfo04.Controls.Add(this.txtname);
            this.gBAudioInfo04.Controls.Add(this.txtMaso);
            this.gBAudioInfo04.Controls.Add(this.lbDesc);
            this.gBAudioInfo04.Controls.Add(this.lbLeng);
            this.gBAudioInfo04.Controls.Add(this.lbExt);
            this.gBAudioInfo04.Controls.Add(this.lbSize);
            this.gBAudioInfo04.Controls.Add(this.lbPath);
            this.gBAudioInfo04.Controls.Add(this.lbname);
            this.gBAudioInfo04.Controls.Add(this.lbMaso);
            this.gBAudioInfo04.Controls.Add(this.listBoxAuFileInfo);
            this.gBAudioInfo04.Controls.Add(this.listBoxAuFile);
            this.gBAudioInfo04.Controls.Add(this.listBoxAuFileSelect);
            this.gBAudioInfo04.Location = new System.Drawing.Point(45, 121);
            this.gBAudioInfo04.Name = "gBAudioInfo04";
            this.gBAudioInfo04.Size = new System.Drawing.Size(639, 426);
            this.gBAudioInfo04.TabIndex = 3;
            this.gBAudioInfo04.TabStop = false;
            this.gBAudioInfo04.Text = "[04 NNGH] QUẢN LÝ THÔNG TIN FILES ÂM THANH";
            // 
            // lbLengs
            // 
            this.lbLengs.AutoSize = true;
            this.lbLengs.Location = new System.Drawing.Point(565, 272);
            this.lbLengs.Name = "lbLengs";
            this.lbLengs.Size = new System.Drawing.Size(51, 16);
            this.lbLengs.TabIndex = 0;
            this.lbLengs.Text = "s (giây)";
            // 
            // lbSizeKB
            // 
            this.lbSizeKB.AutoSize = true;
            this.lbSizeKB.Location = new System.Drawing.Point(565, 195);
            this.lbSizeKB.Name = "lbSizeKB";
            this.lbSizeKB.Size = new System.Drawing.Size(39, 16);
            this.lbSizeKB.TabIndex = 0;
            this.lbSizeKB.Text = "KB(s)";
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "desciption", true));
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(275, 330);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(319, 68);
            this.txtDesc.TabIndex = 8;
            // 
            // aUDIOFILESBindingSource
            // 
            this.aUDIOFILESBindingSource.DataMember = "AUDIOFILES";
            this.aUDIOFILESBindingSource.DataSource = this.a04NNGHHandpanDataSet;
            // 
            // a04NNGHHandpanDataSet
            // 
            this.a04NNGHHandpanDataSet.DataSetName = "A04NNGHHandpanDataSet";
            this.a04NNGHHandpanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLeng
            // 
            this.txtLeng.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "length", true));
            this.txtLeng.Enabled = false;
            this.txtLeng.Location = new System.Drawing.Point(429, 269);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(130, 22);
            this.txtLeng.TabIndex = 7;
            this.txtLeng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExt
            // 
            this.txtExt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "extension", true));
            this.txtExt.Enabled = false;
            this.txtExt.Location = new System.Drawing.Point(429, 231);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(165, 22);
            this.txtExt.TabIndex = 6;
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "size", true));
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(429, 192);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(130, 22);
            this.txtSize.TabIndex = 5;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtpath
            // 
            this.txtpath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "filepath", true));
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(429, 147);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(165, 22);
            this.txtpath.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "filename", true));
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(429, 111);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(165, 22);
            this.txtname.TabIndex = 3;
            // 
            // txtMaso
            // 
            this.txtMaso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "ms", true));
            this.txtMaso.Enabled = false;
            this.txtMaso.Location = new System.Drawing.Point(429, 74);
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.Size = new System.Drawing.Size(165, 22);
            this.txtMaso.TabIndex = 2;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(367, 302);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(43, 16);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "Mô tả:";
            // 
            // lbLeng
            // 
            this.lbLeng.AutoSize = true;
            this.lbLeng.Location = new System.Drawing.Point(344, 269);
            this.lbLeng.Name = "lbLeng";
            this.lbLeng.Size = new System.Drawing.Size(66, 16);
            this.lbLeng.TabIndex = 0;
            this.lbLeng.Text = "Chiều dài:";
            // 
            // lbExt
            // 
            this.lbExt.AutoSize = true;
            this.lbExt.Location = new System.Drawing.Point(288, 231);
            this.lbExt.Name = "lbExt";
            this.lbExt.Size = new System.Drawing.Size(122, 16);
            this.lbExt.TabIndex = 0;
            this.lbExt.Text = "Phần mở rộng (Ext):";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(340, 192);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(70, 16);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Kích thước:";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(306, 147);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(104, 16);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "Đường dẫn path:";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(356, 111);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(54, 16);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Tên file:";
            // 
            // lbMaso
            // 
            this.lbMaso.AutoSize = true;
            this.lbMaso.Location = new System.Drawing.Point(363, 74);
            this.lbMaso.Name = "lbMaso";
            this.lbMaso.Size = new System.Drawing.Size(47, 16);
            this.lbMaso.TabIndex = 0;
            this.lbMaso.Text = "Mã số:";
            // 
            // listBoxAuFileInfo
            // 
            this.listBoxAuFileInfo.AutoSize = true;
            this.listBoxAuFileInfo.Location = new System.Drawing.Point(288, 31);
            this.listBoxAuFileInfo.Name = "listBoxAuFileInfo";
            this.listBoxAuFileInfo.Size = new System.Drawing.Size(197, 16);
            this.listBoxAuFileInfo.TabIndex = 0;
            this.listBoxAuFileInfo.Text = "Thông tin chi tiết về file âm thanh";
            // 
            // listBoxAuFile
            // 
            this.listBoxAuFile.DataSource = this.aUDIOFILESBindingSource;
            this.listBoxAuFile.DisplayMember = "filename";
            this.listBoxAuFile.FormattingEnabled = true;
            this.listBoxAuFile.ItemHeight = 16;
            this.listBoxAuFile.Location = new System.Drawing.Point(17, 74);
            this.listBoxAuFile.Name = "listBoxAuFile";
            this.listBoxAuFile.Size = new System.Drawing.Size(233, 324);
            this.listBoxAuFile.TabIndex = 1;
            this.listBoxAuFile.ValueMember = "ms";
            // 
            // listBoxAuFileSelect
            // 
            this.listBoxAuFileSelect.AutoSize = true;
            this.listBoxAuFileSelect.Location = new System.Drawing.Point(6, 31);
            this.listBoxAuFileSelect.Name = "listBoxAuFileSelect";
            this.listBoxAuFileSelect.Size = new System.Drawing.Size(115, 16);
            this.listBoxAuFileSelect.TabIndex = 0;
            this.listBoxAuFileSelect.Text = "Chọn file âm thanh";
            // 
            // gBAudioTest04
            // 
            this.gBAudioTest04.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gBAudioTest04.Controls.Add(this.btnPause);
            this.gBAudioTest04.Controls.Add(this.btnStop);
            this.gBAudioTest04.Controls.Add(this.btnFast);
            this.gBAudioTest04.Controls.Add(this.btnSlow);
            this.gBAudioTest04.Controls.Add(this.btnFirst);
            this.gBAudioTest04.Controls.Add(this.btnPre);
            this.gBAudioTest04.Controls.Add(this.btnNext);
            this.gBAudioTest04.Controls.Add(this.btnLast);
            this.gBAudioTest04.Controls.Add(this.btnPlay);
            this.gBAudioTest04.Controls.Add(this.axWMP);
            this.gBAudioTest04.Location = new System.Drawing.Point(690, 121);
            this.gBAudioTest04.Name = "gBAudioTest04";
            this.gBAudioTest04.Size = new System.Drawing.Size(510, 426);
            this.gBAudioTest04.TabIndex = 4;
            this.gBAudioTest04.TabStop = false;
            this.gBAudioTest04.Text = "[04 NNGH] KIỂM (NGHE THỬ: TEST) FILES ÂM THANH";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(114, 326);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(89, 31);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(209, 326);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 31);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(304, 326);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(89, 31);
            this.btnFast.TabIndex = 16;
            this.btnFast.Text = "Faster";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(406, 326);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(89, 31);
            this.btnSlow.TabIndex = 17;
            this.btnSlow.Text = "Slower";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(44, 367);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(89, 31);
            this.btnFirst.TabIndex = 18;
            this.btnFirst.Text = "First Track";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnPFirst_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(163, 367);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(89, 31);
            this.btnPre.TabIndex = 19;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(277, 367);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 31);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next Track";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(386, 367);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(89, 31);
            this.btnLast.TabIndex = 21;
            this.btnLast.Text = "Last Track";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(19, 326);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(89, 31);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // axWMP
            // 
            this.axWMP.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.aUDIOFILESBindingSource, "filepath", true));
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(19, 31);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(476, 279);
            this.axWMP.TabIndex = 24;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(62, 570);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 31);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Nạp file mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(188, 570);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(127, 31);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Sửa thông tin file";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(363, 570);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(127, 31);
            this.btnRecord.TabIndex = 11;
            this.btnRecord.Text = "Ghi âm file mới";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 570);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa file";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(804, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(209, 31);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Đóng form, về màn hình chính";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1058, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Thoát App";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // aUDIOFILESTableAdapter
            // 
            this.aUDIOFILESTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frNNGH2WMP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gBAudioTest04);
            this.Controls.Add(this.gBAudioInfo04);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frNNGH2WMP";
            this.Text = "[04 NNGH] QUẢN LÝ FILEs ÂM THANH DÙNG THƯ VIỆN WMP.dll CỦA MS. WINDOWS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frNNGH2WMP_FormClosing);
            this.Load += new System.EventHandler(this.frNNGH2WMP_Load);
            this.gBAudioInfo04.ResumeLayout(false);
            this.gBAudioInfo04.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a04NNGHHandpanDataSet)).EndInit();
            this.gBAudioTest04.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gBAudioInfo04;
        private System.Windows.Forms.GroupBox gBAudioTest04;
        private System.Windows.Forms.Label listBoxAuFileSelect;
        private System.Windows.Forms.Label listBoxAuFileInfo;
        private System.Windows.Forms.ListBox listBoxAuFile;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbLeng;
        private System.Windows.Forms.Label lbExt;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbMaso;
        private System.Windows.Forms.Label lbSizeKB;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtMaso;
        private System.Windows.Forms.Label lbLengs;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private A04NNGHHandpanDataSet a04NNGHHandpanDataSet;
        private System.Windows.Forms.BindingSource aUDIOFILESBindingSource;
        private A04NNGHHandpanDataSetTableAdapters.AUDIOFILESTableAdapter aUDIOFILESTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}