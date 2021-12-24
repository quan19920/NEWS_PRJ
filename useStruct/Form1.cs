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


namespace useStruct
{
    struct DSSV
    {
        public string HoTen;
        public string gioitinh;
        public int MSSV;
        public double DQT;
        public double DKT;
        public double tongket;

    }

    public partial class Form1 : Form
    {
        int sl = 0;
        int flag;
        public Form1()
        {
            InitializeComponent();
        }

        DSSV[] danhsachSV = new DSSV[100];
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (rdbNam.Checked == true)
            {
                danhsachSV[sl].HoTen = txtHoTen.Text;
                danhsachSV[sl].gioitinh = "Nam";
                danhsachSV[sl].MSSV = Convert.ToInt32(txtMSSV.Text);
                danhsachSV[sl].DQT = Convert.ToDouble(txtDQT.Text);
                danhsachSV[sl].DKT = Convert.ToDouble(txtDKT.Text);
                danhsachSV[sl].tongket = danhsachSV[sl].DQT * 0.3 + danhsachSV[sl].DKT * 0.7;
            }
            else
            {
                danhsachSV[sl].HoTen = txtHoTen.Text;
                danhsachSV[sl].gioitinh = "Nữ";
                danhsachSV[sl].MSSV = Convert.ToInt32(txtMSSV.Text);
                danhsachSV[sl].DQT = Convert.ToDouble(txtDQT.Text);
                danhsachSV[sl].DKT = Convert.ToDouble(txtDKT.Text);
                danhsachSV[sl].tongket = danhsachSV[sl].DQT * 0.3 + danhsachSV[sl].DKT * 0.7;
            }

            dgv_DSSV.Rows.Add(sl + 1, danhsachSV[sl].HoTen, danhsachSV[sl].gioitinh, danhsachSV[sl].MSSV, danhsachSV[sl].DQT, danhsachSV[sl].DKT, danhsachSV[sl].tongket);
            sl++;
            txtHoTen.Clear();
            txtMSSV.Clear();
            txtDKT.Clear();
            txtDQT.Clear();
        }

        private void btnFIx_Click(object sender, EventArgs e)
        {
            int index;
            index = dgv_DSSV.CurrentRow.Index;
            if (index >= 0)
            {
                dgv_DSSV.Rows[index].Cells["dgv_hoten"].Value = txtHoTen.Text;
                dgv_DSSV.Rows[index].Cells["dgv_MSSV"].Value = txtMSSV.Text;
                dgv_DSSV.Rows[index].Cells["dgv_dqt"].Value = txtDQT.Text;
                dgv_DSSV.Rows[index].Cells["dgv_dkt"].Value = txtDKT.Text;
                double TongKet;
                TongKet = Convert.ToDouble(txtDQT.Text) * 0.3 + Convert.ToDouble(txtDKT.Text) * 0.7;
                dgv_DSSV.Rows[index].Cells["dgv_tongket"].Value = TongKet;

            }
            else
            {
                MessageBox.Show("Chưa chọn ô cần xóa");
            }

        }

        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_DSSV.CurrentRow.Index;
            var cell = dgv_DSSV.CurrentCell;
            if (index >= 0 && cell != null)
            {
                txtHoTen.Text = dgv_DSSV.Rows[index].Cells["dgv_hoten"].Value.ToString();
                txtMSSV.Text = dgv_DSSV.Rows[index].Cells["dgv_MSSV"].Value.ToString();
                txtDQT.Text = dgv_DSSV.Rows[index].Cells["dgv_dqt"].Value.ToString();
                txtDKT.Text = dgv_DSSV.Rows[index].Cells["dgv_dkt"].Value.ToString();
                btnFIx.Enabled = true;
                btnDEL.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ô sửa");
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
                    str += dgv_DSSV.Rows[i].Cells["dgv_hoten"].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells["dgv_gioitinh"].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells["dgv_MSSV"].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells["dgv_dqt"].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells["dgv_dkt"].Value + "|";
                    str += dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value + "|";

                    filewriter.WriteLine(str);
                }
                filewriter.Close();
            }
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

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
            {
                danhsachSV[i].HoTen = dgv_DSSV.Rows[i].Cells["dgv_hoten"].Value.ToString();
                danhsachSV[i].MSSV = Convert.ToInt32(dgv_DSSV.Rows[i].Cells["dgv_MSSV"].Value);
                danhsachSV[i].DQT = Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_dqt"].Value);
                danhsachSV[i].DKT = Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_dkt"].Value);
                danhsachSV[i].tongket = Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value);
            }

        }

        private void toolStripButtonTBC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
            {
                dgv_DSSV.Rows[i].Cells["dgv_TBHK"].Value = (danhsachSV[i].DKT + danhsachSV[i].DQT) / 2;
            }
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(dgv_DSSV.Rows[0].Cells["dgv_tongket"].Value);

            for (int i = 1; i < dgv_DSSV.Rows.Count; i++)
            {
                //double compare = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value);
                if (Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value) >= max)
                {
                    max = Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value);
                }
            }
            for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
            {
                if (Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value) == max)
                {
                    txtHoTenMax.Text = dgv_DSSV.Rows[i].Cells["dgv_hoten"].Value.ToString();
                    txtMSSVMax.Text = dgv_DSSV.Rows[i].Cells["dgv_MSSV"].Value.ToString();
                    txtDiemQTMax.Text = dgv_DSSV.Rows[i].Cells["dgv_dqt"].Value.ToString();
                    txtDiemKTMax.Text = dgv_DSSV.Rows[i].Cells["dgv_dkt"].Value.ToString();
                    txtDiemTongKetMax.Text = dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value.ToString();
                }

            }
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double min = Convert.ToDouble(dgv_DSSV.Rows[0].Cells["dgv_tongket"].Value);

            for (int i = 1; i < dgv_DSSV.Rows.Count; i++)
            {
                //double compare = Convert.ToDouble(dgv_DSSV.Rows[i].Cells[5].Value);
                if (Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value) <= min)
                {
                    min = Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value);
                }
            }
            for (int i = 0; i < dgv_DSSV.Rows.Count; i++)
            {
                if (Convert.ToDouble(dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value) == min)
                {
                    txtHoTenMax.Text = dgv_DSSV.Rows[i].Cells["dgv_hoten"].Value.ToString();
                    txtMSSVMax.Text = dgv_DSSV.Rows[i].Cells["dgv_MSSV"].Value.ToString();
                    txtDiemQTMax.Text = dgv_DSSV.Rows[i].Cells["dgv_dqt"].Value.ToString();
                    txtDiemKTMax.Text = dgv_DSSV.Rows[i].Cells["dgv_dkt"].Value.ToString();
                    txtDiemTongKetMax.Text = dgv_DSSV.Rows[i].Cells["dgv_tongket"].Value.ToString();
                }

            }
        }

        private void importToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromDGV(dgv_DSSV);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite(@"d:\EmpOut1.xml"));
        }

        
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach(DataGridViewColumn column in dgv.Columns)
            {
                if(column.Visible)
                {
                    dt.Columns.Add();
                }    
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach(DataGridViewRow row in dgv.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        
    }
}
