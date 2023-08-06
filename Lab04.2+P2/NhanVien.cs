using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._2_P2
{
     abstract class NhanVien
    {
        private string ten;
        private string diachi;

        protected NhanVien(string ten, string diachi)
        {
            this.ten = ten;
            this.diachi = diachi;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }

        public abstract double TinhLuong();
        public abstract void Hienthi();
    }
    class NhanVienBanHang : NhanVien
    {
        public int Soluongbanduoc { get; set; }
        public NhanVienBanHang(string ten, string diachi, int soluongbanduoc) : base(ten, diachi)
        {
            Soluongbanduoc = soluongbanduoc;
        }

        public override void Hienthi()
        {
            Console.WriteLine("Hien thi {0},{1},{2} " ,Ten,Diachi,Soluongbanduoc);
        }

        public override double TinhLuong()
        {
            return Soluongbanduoc;
        }
    }

    class CongNhan : NhanVien
    {
        public CongNhan(string ten, string diachi, int soluongsp) : base(ten, diachi)
        {
            Soluongsanpham = soluongsp;
        }

        public int Soluongsanpham { get; set; }
        public override void Hienthi()
        {
            Console.WriteLine("Hien thi {0},{1},{2} ", Ten, Diachi, Soluongsanpham);
        }

        public override double TinhLuong()
        {
            return Soluongsanpham;
        }
    }


}
