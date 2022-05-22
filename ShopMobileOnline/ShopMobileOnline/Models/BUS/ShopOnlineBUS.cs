using ShopMobileOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMobileOnline.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopMobileOnlineConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(String masp)
        {
            var db = new ShopMobileOnlineConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0",masp);
        }
    }
}

