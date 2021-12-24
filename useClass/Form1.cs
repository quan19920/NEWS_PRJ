using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace useClass
{
    public partial class Form1 : Form
    {
        DSSinhVien[] danhsachSV = new DSSinhVien[100];
        int sl = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // hàm kiểm tra dữ liệu trong ô text
        static bool IsNumeric(string value)
        {
            try
            {
                double number;
                bool result = double.TryParse(value, out number);
                return result;
            }
            catch (Exception ex) { return false; }
        }

        private void tsbNewFile_Click(object sender, EventArgs e)
        {
            dgv_DSSV.Rows.Clear();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtHoTen.Text) == true)
            {
                MessageBox.Show("Nhập sai sữ liệu rồi");
            }
            else if (IsNumeric(txtMSSV.Text) == false | IsNumeric(txtDQT.Text) == false | IsNumeric(txtDKT.Text) == false)
            {
                MessageBox.Show("Nhập sai sữ liệu rồi");
            }
            else
            {
                danhsachSV[sl] = new DSSinhVien();
                danhsachSV[sl].HoTen = txtHoTen.Text;
                danhsachSV[sl].masoSV = Convert.ToInt32(txtMSSV.Text);
                danhsachSV[sl].diemQT = Convert.ToDouble(txtDQT.Text);
                danhsachSV[sl].diemKT = Convert.ToDouble(txtDKT.Text);
                dgv_DSSV.Rows.Add(sl + 1, danhsachSV[sl].HoTen, danhsachSV[sl].masoSV, danhsachSV[sl].diemQT, danhsachSV[sl].diemKT, danhsachSV[sl].diemTongket().ToString());
                sl++;
                txtHoTen.Clear();
                txtMSSV.Clear();
                txtDQT.Clear();
                txtDKT.Clear();

            }
        }

        private void btnFIx_Click(object sender, EventArgs e)
        {
            int index;
            index = dgv_DSSV.CurrentRow.Index;
            if (index >= 0)
            {
                dgv_DSSV.Rows[index].Cells[1].Value = txtHoTen.Text;
                dgv_DSSV.Rows[index].Cells[2].Value = txtMSSV.Text;
                dgv_DSSV.Rows[index].Cells[3].Value = txtDQT.Text;
                dgv_DSSV.Rows[index].Cells[4].Value = txtDKT.Text;
                double TongKet;
                TongKet = Convert.ToDouble(txtDQT.Text) * 0.3 + Convert.ToDouble(txtDKT.Text) * 0.7;
                dgv_DSSV.Rows[index].Cells[5].Value = TongKet;
            }
            else
            {
                MessageBox.Show("Chưa chọn ô cần xóa");
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
            {
                danhsachSV[i].HoTen = dgv_DSSV.Rows[i].Cells[1].Value.ToString();
                danhsachSV[i].masoSV = Convert.ToInt32(dgv_DSSV.Rows[i].Cells[2].Value);
                danhsachSV[i].diemQT = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[3].Value);
                danhsachSV[i].diemKT = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[4].Value);
            }

            btnDEL.Enabled = false;
            btnFIx.Enabled = false;
            txtHoTen.Clear();
            txtMSSV.Clear();
            txtDQT.Clear();
            txtDKT.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDEL.Enabled = false;
            btnFIx.Enabled = false;
            txtHoTen.Clear();
            txtMSSV.Clear();
            txtDQT.Clear();
            txtDKT.Clear();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            int index = dgv_DSSV.CurrentRow.Index;
            if (index >= 0)
            {
                dgv_DSSV.Rows.RemoveAt(index);
                MessageBox.Show("Đã xóa thành công");
                for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
                {
                    dgv_DSSV.Rows[i].Cells[0].Value = i + 1;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dữ liệu");
            }
        }

        private void importExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ExcelPath = "";
            DataTable ExcelTable = new DataTable();
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel File|*.xls;*.xlsx;*" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($" The file path is: {openFile.FileName}");
                    ExcelPath = openFile.FileName;
                    ExcelTable = LoadExcelSheet(ExcelPath, "Sheet1");
                    dgv_DSSV.DataSource = ExcelTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file");
                }
            }

        }
        // Sử dụng thư viện OleDb, hàm lấy dữ liệu từ phần mềm Excel (lấy dữ liệu của 1 sheet trong Excel)
        public DataTable LoadExcelSheet(string aExcelFilePath, string aSheetName)
        {
            using (OleDbConnection ExcelConnection = new OleDbConnection()
            { ConnectionString = $@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {aExcelFilePath };
            Extended Properties = 'Excel 12.0 Xml;HDR=YES;'" })
            {
                DataTable SheetData = new DataTable();
                OleDbCommand SQLCommand = new OleDbCommand($"Select * From [{aSheetName}$]", ExcelConnection);
                ExcelConnection.Open();
                ((OleDbDataAdapter)new OleDbDataAdapter(SQLCommand)).Fill(SheetData);
                ExcelConnection.Close();
                return SheetData;
            }
        }

        private void importNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_New.Filter = "TextFile |*.txt |FileWord |*.doc | AllFile |*.";
            var result = openFileDialog_New.ShowDialog();
            string path = openFileDialog_New.FileName;
            if (path == null | path == "")
            {
                MessageBox.Show("Không tìm thấy file");
            }
            else if (result == DialogResult.OK)
            {
                dgv_DSSV.Rows.Clear();
                StreamReader fileread = new StreamReader(path);
                int soluong = Convert.ToInt32(fileread.ReadLine());
                for (int i = 0; i < soluong; i++)
                {
                    string str;
                    str = fileread.ReadLine();
                    string[] dulieu;
                    dulieu = str.Split('|'); // chia từng phần tử dc ngăn cách bởi dấu | tạo thành mảng [1,2,3,4]
                    dgv_DSSV.Rows.Add(dulieu[0], dulieu[1], dulieu[2], dulieu[3], dulieu[4]);
                }
                fileread.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy file");
            }
        }

        private void exportExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_DSSV.Rows.Count > 0)
            {
                // khởi tạo hàm xuất excel
                Microsoft.Office.Interop.Excel.Application exportExcel = new Microsoft.Office.Interop.Excel.Application();
                exportExcel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_DSSV.Columns.Count + 1; i++)
                {
                    exportExcel.Cells[1, i] = dgv_DSSV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_DSSV.Columns.Count; j++)
                    {
                        exportExcel.Cells[i + 2, j + 1] = dgv_DSSV.Rows[i].Cells[j].Value.ToString();
                    }
                }
                exportExcel.Columns.AutoFit();
                exportExcel.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void exportNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog_Luu.Filter = "TextFile |*.txt |FileWord |*.doc | AllFile |*.";

            saveFileDialog_Luu.ShowDialog();
            string path = saveFileDialog_Luu.FileName;
            if (path == null | path == "")
            {
                MessageBox.Show("Chưa lưu file");
            }
            else
            {
                StreamWriter filewriter = new StreamWriter(path); // khởi tạo trình lưu tên file
                filewriter.WriteLine(dgv_DSSV.Rows.Count);
                for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
                {

                    string str = "";
                    str += dgv_DSSV.Rows[i].Cells[0].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells[1].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells[2].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells[3].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells[4].Value + "|";
                    filewriter.WriteLine(str);
                }
                filewriter.Close();
            }
        }

        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_DSSV.CurrentRow.Index;
            var cell = dgv_DSSV.CurrentCell;
            if (index >= 0 && cell != null)
            {
                txtHoTen.Text = dgv_DSSV.Rows[index].Cells[1].Value.ToString();
                txtMSSV.Text = dgv_DSSV.Rows[index].Cells[2].Value.ToString();
                txtDQT.Text = dgv_DSSV.Rows[index].Cells[3].Value.ToString();
                txtDKT.Text = dgv_DSSV.Rows[index].Cells[4].Value.ToString();
                btnFIx.Enabled = true;
                btnDEL.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ô sửa");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(dgv_DSSV.Rows[0].Cells[5].Value);

            for (int i = 1; i < dgv_DSSV.Rows.Count; i++)
            {
                //double compare = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value);
                if (Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value) >= max)
                {
                    max = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value);
                }
            }
            for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
            {
                if(Convert.ToDouble (dgv_DSSV.Rows[i].Cells[5].Value) == max)
                {
                    txtHoTenMax.Text = dgv_DSSV.Rows[i].Cells[1].Value.ToString();
                    txtMSSVMax.Text = dgv_DSSV.Rows[i].Cells[2].Value.ToString();
                    txtDiemQTMax.Text = dgv_DSSV.Rows[i].Cells[3].Value.ToString();
                    txtDiemKTMax.Text = dgv_DSSV.Rows[i].Cells[4].Value.ToString();
                    txtDiemTongKetMax.Text = dgv_DSSV.Rows[i].Cells[5].Value.ToString();
                }    
                
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            double min = Convert.ToDouble(dgv_DSSV.Rows[0].Cells[5].Value);

            for (int i = 1; i < dgv_DSSV.Rows.Count; i++)
            {
                //double compare = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value);
                if (Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value) <= min)
                {
                    min = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value);
                    txtHoTenMax.Text = dgv_DSSV.Rows[i].Cells[1].Value.ToString();
                    txtMSSVMax.Text = dgv_DSSV.Rows[i].Cells[2].Value.ToString();
                    txtDiemQTMax.Text = dgv_DSSV.Rows[i].Cells[3].Value.ToString();
                    txtDiemKTMax.Text = dgv_DSSV.Rows[i].Cells[4].Value.ToString();
                    txtDiemTongKetMax.Text = dgv_DSSV.Rows[i].Cells[5].Value.ToString();
                }
                //else
                //{
                //    txtHoTenMax.Text = dgv_DSSV.Rows[0].Cells[1].Value.ToString();
                //    txtMSSVMax.Text = dgv_DSSV.Rows[0].Cells[2].Value.ToString();
                //    txtDiemQTMax.Text = dgv_DSSV.Rows[0].Cells[3].Value.ToString();
                //    txtDiemKTMax.Text = dgv_DSSV.Rows[0].Cells[4].Value.ToString();
                //    txtDiemTongKetMax.Text = dgv_DSSV.Rows[0].Cells[5].Value.ToString();
                //}
            }
        }
    }
}
