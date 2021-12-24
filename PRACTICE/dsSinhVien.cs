using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    class dsSinhVien
    {
        private string HoTen { get; set; }
        private int MSSV { get; set; }
        private double DQT { get; set; }
        private double DKT { get; set; }

        public double diemTongket()
        {
            return 0.3 * DQT + 0.7 * DKT;
        }

    }
}
