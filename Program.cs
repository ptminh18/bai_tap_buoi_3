using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMinh_Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            //TamGiac tamgiac = new TamGiac();
            TamGiac tamgiac1 = new TamGiac(3,4,5);
            Console.WriteLine("Chu vi tam giac: {0}", tamgiac1.TinhChuVi());
            Console.WriteLine("Dien tich tam giac: {0:N2}", tamgiac1.TinhDienTich());
            tamgiac1.OutPut();
            //b
            
            Console.ReadKey();
        }
    }
}
