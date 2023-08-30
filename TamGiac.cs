using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMinh_Buoi3
{
    class TamGiac
    {
        private double ma;

        public double Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private double mb;

        public double Mb
        {
            get { return mb; }
            set { mb = value; }
        }
        private double mc;

        public double Mc
        {
            get { return mc; }
            set { mc = value; }
        }

        public TamGiac()
        {
            ma = 0.0;
            mb = 0.0;
            mc = 0.0;
        }
        public TamGiac(double ma, double mb, double mc)
        {
            //
            if (ma == 0 || mb == 0 || mc == 0 || (ma + mb) < mc || (mb + mc) < ma || (ma + mc) < mb)
            //
            {
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }
            else
            {
                this.ma = ma;
                this.mb = mb;
                this.mc = mc;
            }
        }


        public double TinhChuVi()
        {
            return ma + mb + mc;
        }
        public double TinhDienTich()
        {
            return (1.0 / 4) * (Math.Sqrt((ma + mb + mc) * (ma + mb - mc) * (mb + mc - ma) * (mc + ma - mb)));
        }
        public string KieuTamGiac()
        {
            if ((ma + mb) >= mc || (mb + mc) >= ma || (ma + mc) >= mb)
            {
                if ((ma == mb && ma != mc) || (mb == mc && mb != ma) || (ma == mc && ma != mb))
                    return "Tam Giac Can";
                else if (ma == mb && mb == mc)
                    return "Tam Giac Deu";
                else if (Math.Pow(ma,2) + Math.Pow(mb,2) == Math.Pow(mc,2) || Math.Pow(mb,2) + Math.Pow(mc,2) == Math.Pow(ma,2) || Math.Pow(ma,2) + Math.Pow(mc,2) == Math.Pow(mb,2))
                    return "Tam Giac Vuong";
                else
                    return "Tam Giac Thuong";
            }
            else
                return "Khong Phai Tam Giac";
        }
        public void OutPut()
        {
            Console.WriteLine("Thong tin 3 canh: ");
            Console.WriteLine("a={0}\nb={1}\nc={2}", ma, mb, mc);
            Console.WriteLine("Kieu tam giac: "+KieuTamGiac());
            Console.WriteLine("Chu vi: {0}\nDien tich: {1}", TinhChuVi(), TinhDienTich());
        }
    }
}
