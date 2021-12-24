
namespace useStruct
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsbOpenFile = new System.Windows.Forms.ToolStripSplitButton();
            this.importExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtDQT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDKT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.tsbSaveFile = new System.Windows.Forms.ToolStripSplitButton();
            this.exportExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog_Luu = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_New = new System.Windows.Forms.OpenFileDialog();
            this.txtDiemTongKetMax = new System.Windows.Forms.TextBox();
            this.txtMSSVMax = new System.Windows.Forms.TextBox();
            this.txtDiemQTMax = new System.Windows.Forms.TextBox();
            this.txtDiemKTMax = new System.Windows.Forms.TextBox();
            this.txtHoTenMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTBC = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMax = new System.Windows.Forms.Button();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.dgv_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dqt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_TBHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnFIx = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.importToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbOpenFile
            // 
            this.tsbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importExcelToolStripMenuItem,
            this.importNotepadToolStripMenuItem});
            this.tsbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenFile.Image")));
            this.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFile.Name = "tsbOpenFile";
            this.tsbOpenFile.Size = new System.Drawing.Size(39, 28);
            this.tsbOpenFile.Text = "toolStripButton2";
            // 
            // importExcelToolStripMenuItem
            // 
            this.importExcelToolStripMenuItem.Name = "importExcelToolStripMenuItem";
            this.importExcelToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.importExcelToolStripMenuItem.Text = "Import Excel";
            // 
            // importNotepadToolStripMenuItem
            // 
            this.importNotepadToolStripMenuItem.Name = "importNotepadToolStripMenuItem";
            this.importNotepadToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.importNotepadToolStripMenuItem.Text = "Import Notepad";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(85, 67);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(191, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtDQT
            // 
            this.txtDQT.Location = new System.Drawing.Point(60, 139);
            this.txtDQT.Name = "txtDQT";
            this.txtDQT.Size = new System.Drawing.Size(64, 22);
            this.txtDQT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // txtDKT
            // 
            this.txtDKT.Location = new System.Drawing.Point(206, 139);
            this.txtDKT.Name = "txtDKT";
            this.txtDKT.Size = new System.Drawing.Size(70, 22);
            this.txtDKT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(85, 26);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(191, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // tsbSaveFile
            // 
            this.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportExcelToolStripMenuItem,
            this.exportNotepadToolStripMenuItem,
            this.importToXMLToolStripMenuItem});
            this.tsbSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveFile.Image")));
            this.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveFile.Name = "tsbSaveFile";
            this.tsbSaveFile.Size = new System.Drawing.Size(39, 28);
            this.tsbSaveFile.Text = "toolStripButton3";
            // 
            // exportExcelToolStripMenuItem
            // 
            this.exportExcelToolStripMenuItem.Name = "exportExcelToolStripMenuItem";
            this.exportExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportExcelToolStripMenuItem.Text = "Export Excel";
            this.exportExcelToolStripMenuItem.Click += new System.EventHandler(this.exportExcelToolStripMenuItem_Click);
            // 
            // exportNotepadToolStripMenuItem
            // 
            this.exportNotepadToolStripMenuItem.Name = "exportNotepadToolStripMenuItem";
            this.exportNotepadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportNotepadToolStripMenuItem.Text = "Export Notepad";
            this.exportNotepadToolStripMenuItem.Click += new System.EventHandler(this.exportNotepadToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // openFileDialog_New
            // 
            this.openFileDialog_New.FileName = "openFileDialog_New";
            // 
            // txtDiemTongKetMax
            // 
            this.txtDiemTongKetMax.Location = new System.Drawing.Point(1119, 258);
            this.txtDiemTongKetMax.Name = "txtDiemTongKetMax";
            this.txtDiemTongKetMax.Size = new System.Drawing.Size(191, 22);
            this.txtDiemTongKetMax.TabIndex = 40;
            // 
            // txtMSSVMax
            // 
            this.txtMSSVMax.Location = new System.Drawing.Point(1119, 179);
            this.txtMSSVMax.Name = "txtMSSVMax";
            this.txtMSSVMax.Size = new System.Drawing.Size(191, 22);
            this.txtMSSVMax.TabIndex = 36;
            // 
            // txtDiemQTMax
            // 
            this.txtDiemQTMax.Location = new System.Drawing.Point(1119, 216);
            this.txtDiemQTMax.Name = "txtDiemQTMax";
            this.txtDiemQTMax.Size = new System.Drawing.Size(64, 22);
            this.txtDiemQTMax.TabIndex = 37;
            // 
            // txtDiemKTMax
            // 
            this.txtDiemKTMax.Location = new System.Drawing.Point(1240, 216);
            this.txtDiemKTMax.Name = "txtDiemKTMax";
            this.txtDiemKTMax.Size = new System.Drawing.Size(70, 22);
            this.txtDiemKTMax.TabIndex = 38;
            // 
            // txtHoTenMax
            // 
            this.txtHoTenMax.Location = new System.Drawing.Point(1119, 138);
            this.txtHoTenMax.Name = "txtHoTenMax";
            this.txtHoTenMax.Size = new System.Drawing.Size(191, 22);
            this.txtHoTenMax.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1151, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Điểm số cao nhất";
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(1218, 314);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(92, 32);
            this.btnMin.TabIndex = 42;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐQT";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewFile,
            this.tsbOpenFile,
            this.tsbSaveFile,
            this.toolStripButton1,
            this.toolStripButtonTBC,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1346, 31);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewFile
            // 
            this.tsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewFile.Image")));
            this.tsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewFile.Name = "tsbNewFile";
            this.tsbNewFile.Size = new System.Drawing.Size(29, 24);
            this.tsbNewFile.Text = "toolStripButton1";
            // 
            // toolStripButtonTBC
            // 
            this.toolStripButtonTBC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTBC.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTBC.Image")));
            this.toolStripButtonTBC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTBC.Name = "toolStripButtonTBC";
            this.toolStripButtonTBC.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonTBC.Text = "toolStripButton2";
            this.toolStripButtonTBC.Click += new System.EventHandler(this.toolStripButtonTBC_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxToolStripMenuItem,
            this.minToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(39, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(1119, 314);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(92, 32);
            this.btnMax.TabIndex = 41;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AllowUserToAddRows = false;
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_STT,
            this.dgv_hoten,
            this.dgv_gioitinh,
            this.dgv_MSSV,
            this.dgv_dqt,
            this.dgv_dkt,
            this.dgv_tongket,
            this.dgv_TBHK});
            this.dgv_DSSV.Location = new System.Drawing.Point(401, 95);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 51;
            this.dgv_DSSV.RowTemplate.Height = 24;
            this.dgv_DSSV.Size = new System.Drawing.Size(681, 277);
            this.dgv_DSSV.TabIndex = 33;
            this.dgv_DSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSV_CellClick);
            // 
            // dgv_STT
            // 
            this.dgv_STT.HeaderText = "STT";
            this.dgv_STT.MinimumWidth = 6;
            this.dgv_STT.Name = "dgv_STT";
            // 
            // dgv_hoten
            // 
            this.dgv_hoten.HeaderText = "Họ và tên";
            this.dgv_hoten.MinimumWidth = 6;
            this.dgv_hoten.Name = "dgv_hoten";
            // 
            // dgv_gioitinh
            // 
            this.dgv_gioitinh.HeaderText = "Giới Tính";
            this.dgv_gioitinh.MinimumWidth = 6;
            this.dgv_gioitinh.Name = "dgv_gioitinh";
            // 
            // dgv_MSSV
            // 
            this.dgv_MSSV.HeaderText = "MSSV";
            this.dgv_MSSV.MinimumWidth = 6;
            this.dgv_MSSV.Name = "dgv_MSSV";
            // 
            // dgv_dqt
            // 
            this.dgv_dqt.HeaderText = "Điểm QT";
            this.dgv_dqt.MinimumWidth = 6;
            this.dgv_dqt.Name = "dgv_dqt";
            // 
            // dgv_dkt
            // 
            this.dgv_dkt.HeaderText = "Điểm KT";
            this.dgv_dkt.MinimumWidth = 6;
            this.dgv_dkt.Name = "dgv_dkt";
            // 
            // dgv_tongket
            // 
            this.dgv_tongket.HeaderText = "Tổng kết";
            this.dgv_tongket.MinimumWidth = 6;
            this.dgv_tongket.Name = "dgv_tongket";
            // 
            // dgv_TBHK
            // 
            this.dgv_TBHK.HeaderText = "TB Học Kì";
            this.dgv_TBHK.MinimumWidth = 6;
            this.dgv_TBHK.Name = "dgv_TBHK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(644, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 39);
            this.label5.TabIndex = 27;
            this.label5.Text = "Student List";
            // 
            // btnDEL
            // 
            this.btnDEL.Location = new System.Drawing.Point(222, 358);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(92, 32);
            this.btnDEL.TabIndex = 30;
            this.btnDEL.Text = "Xóa";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnFIx
            // 
            this.btnFIx.Location = new System.Drawing.Point(222, 293);
            this.btnFIx.Name = "btnFIx";
            this.btnFIx.Size = new System.Drawing.Size(92, 32);
            this.btnFIx.TabIndex = 31;
            this.btnFIx.Text = "Sửa";
            this.btnFIx.UseVisualStyleBackColor = true;
            this.btnFIx.Click += new System.EventHandler(this.btnFIx_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(84, 293);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(92, 32);
            this.btnADD.TabIndex = 32;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtDQT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDKT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(38, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 185);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(216, 95);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 44;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(80, 95);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 43;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐKT";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(84, 358);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(92, 32);
            this.btnSAVE.TabIndex = 29;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // importToXMLToolStripMenuItem
            // 
            this.importToXMLToolStripMenuItem.Name = "importToXMLToolStripMenuItem";
            this.importToXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToXMLToolStripMenuItem.Text = "Import to XML";
            this.importToXMLToolStripMenuItem.Click += new System.EventHandler(this.importToXMLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 456);
            this.Controls.Add(this.txtDiemTongKetMax);
            this.Controls.Add(this.txtMSSVMax);
            this.Controls.Add(this.txtDiemQTMax);
            this.Controls.Add(this.txtDiemKTMax);
            this.Controls.Add(this.txtHoTenMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnFIx);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSAVE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSplitButton tsbOpenFile;
        private System.Windows.Forms.ToolStripMenuItem importExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importNotepadToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtDQT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ToolStripSplitButton tsbSaveFile;
        private System.Windows.Forms.ToolStripMenuItem exportExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportNotepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Luu;
        private System.Windows.Forms.OpenFileDialog openFileDialog_New;
        private System.Windows.Forms.TextBox txtDiemTongKetMax;
        private System.Windows.Forms.TextBox txtMSSVMax;
        private System.Windows.Forms.TextBox txtDiemQTMax;
        private System.Windows.Forms.TextBox txtDiemKTMax;
        private System.Windows.Forms.TextBox txtHoTenMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewFile;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnFIx;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.ToolStripButton toolStripButtonTBC;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dqt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_TBHK;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToXMLToolStripMenuItem;
    }
}

