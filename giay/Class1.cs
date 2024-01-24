using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giay
{
    internal class Giay
    {
        public Giay(int giayID, string tenGiay, string thuongHieu, int size, string mauSac, int gia, int tonKho)
        {
            this.giayID = giayID;
            this.tenGiay = tenGiay;
            this.thuongHieu = thuongHieu;
            this.size = size;
            this.mauSac = mauSac;
            Gia = gia;
            this.tonKho = tonKho;
        }
        public void cn1()
        {
            
        }
        public int giayID { get; set; }
        public string tenGiay { get; set; }
        public string thuongHieu { get; set;}
        public double size { get; set; }
        public string mauSac { get; set; } 
        public int Gia { get; set; }
        public int tonKho { get; set;}
        
    }
}
