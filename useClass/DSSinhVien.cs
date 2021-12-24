using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useClass
{
    class DSSinhVien
    {
        private string Name;
        private int MSSV;
        private double DQT;
        private double DKT;

        public string HoTen
        {
            get { return Name; }
            set { Name = value; }
        }
        public int masoSV
        {
            get { return MSSV; }
            set { MSSV = value; }
        }
        public double diemQT
        {
            get { return DQT; }
            set { DQT = value; }
        }
        public double diemKT
        {
            get { return DKT; }
            set { DKT = value; }
        }

        public double diemTongket()
        {
            return 0.3 * diemQT + 0.7 * diemKT;
        }
    }
}
