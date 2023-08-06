using Lab04._2_P2;

internal class Program
{
    private static void Main(string[] args)
    {
        NhanVienBanHang nv = new NhanVienBanHang("a","HN",10000);
        nv.Hienthi();
        Console.WriteLine("Luong: " + nv.TinhLuong());

        CongNhan cn = new CongNhan("a", "a", 8909);
        cn.Hienthi();
        Console.WriteLine("Luong: " + cn.TinhLuong());
    }
}