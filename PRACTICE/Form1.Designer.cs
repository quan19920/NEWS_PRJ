
namespace PRACTICE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtDKT = new System.Windows.Forms.TextBox();
            this.txtDQT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnFIx = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.dgv_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dqt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_Luu = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_New = new System.Windows.Forms.OpenFileDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐQT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐKT";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(85, 26);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(191, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(85, 67);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(191, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtDKT
            // 
            this.txtDKT.Location = new System.Drawing.Point(206, 104);
            this.txtDKT.Name = "txtDKT";
            this.txtDKT.Size = new System.Drawing.Size(70, 22);
            this.txtDKT.TabIndex = 1;
            // 
            // txtDQT
            // 
            this.txtDQT.Location = new System.Drawing.Point(74, 104);
            this.txtDQT.Name = "txtDQT";
            this.txtDQT.Size = new System.Drawing.Size(64, 22);
            this.txtDQT.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtDQT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDKT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(41, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(74, 275);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(92, 32);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnFIx
            // 
            this.btnFIx.Location = new System.Drawing.Point(212, 275);
            this.btnFIx.Name = "btnFIx";
            this.btnFIx.Size = new System.Drawing.Size(92, 32);
            this.btnFIx.TabIndex = 3;
            this.btnFIx.Text = "Sửa";
            this.btnFIx.UseVisualStyleBackColor = true;
            this.btnFIx.Click += new System.EventHandler(this.btnFIx_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.Location = new System.Drawing.Point(212, 340);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(92, 32);
            this.btnDEL.TabIndex = 3;
            this.btnDEL.Text = "Xóa";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(74, 340);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(92, 32);
            this.btnSAVE.TabIndex = 3;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AllowUserToAddRows = false;
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DSSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_STT,
            this.dgv_hoten,
            this.dgv_MSSV,
            this.dgv_dqt,
            this.dgv_dkt,
            this.dgv_tongket});
            this.dgv_DSSV.Location = new System.Drawing.Point(404, 95);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 51;
            this.dgv_DSSV.RowTemplate.Height = 24;
            this.dgv_DSSV.Size = new System.Drawing.Size(681, 277);
            this.dgv_DSSV.TabIndex = 4;
            this.dgv_DSSV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_DSSV_CellMouseClick);
            // 
            // dgv_STT
            // 
            this.dgv_STT.HeaderText = "STT";
            this.dgv_STT.MinimumWidth = 6;
            this.dgv_STT.Name = "dgv_STT";
            this.dgv_STT.Width = 64;
            // 
            // dgv_hoten
            // 
            this.dgv_hoten.HeaderText = "Họ và tên";
            this.dgv_hoten.MinimumWidth = 6;
            this.dgv_hoten.Name = "dgv_hoten";
            this.dgv_hoten.Width = 98;
            // 
            // dgv_MSSV
            // 
            this.dgv_MSSV.HeaderText = "MSSV";
            this.dgv_MSSV.MinimumWidth = 6;
            this.dgv_MSSV.Name = "dgv_MSSV";
            this.dgv_MSSV.Width = 75;
            // 
            // dgv_dqt
            // 
            this.dgv_dqt.HeaderText = "Điểm QT";
            this.dgv_dqt.MinimumWidth = 6;
            this.dgv_dqt.Name = "dgv_dqt";
            this.dgv_dqt.Width = 93;
            // 
            // dgv_dkt
            // 
            this.dgv_dkt.HeaderText = "Điểm KT";
            this.dgv_dkt.MinimumWidth = 6;
            this.dgv_dkt.Name = "dgv_dkt";
            this.dgv_dkt.Width = 91;
            // 
            // dgv_tongket
            // 
            this.dgv_tongket.HeaderText = "Tổng kết";
            this.dgv_tongket.MinimumWidth = 6;
            this.dgv_tongket.Name = "dgv_tongket";
            this.dgv_tongket.Width = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(644, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student List";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // openFileDialog_New
            // 
            this.openFileDialog_New.FileName = "openFileDialog_New";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(74, 402);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(95, 36);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(212, 402);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(95, 36);
            this.btnImportExcel.TabIndex = 7;
            this.btnImportExcel.Text = "Import Data";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 450);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnFIx);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtDKT;
        private System.Windows.Forms.TextBox txtDQT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnFIx;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dqt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tongket;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Luu;
        private System.Windows.Forms.OpenFileDialog openFileDialog_New;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnImportExcel;
    }
}

