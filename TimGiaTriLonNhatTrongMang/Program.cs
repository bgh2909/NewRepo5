using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimGiaTriLonNhatTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //nhap kich thuoc mang
            int so; // khai bao bien su dung de luu tru kich thuoc mang
            int[] mang; //khai bao mang kieu so nguyen (chua co kich thuoc cu the)

            do //dung cau lenh lap de tao dieu kien cho kich thuoc mang
            {
                Console.WriteLine("Nhap gia tri kich thuoc mang: "); //nhap kich thuoc mang tu ban phim
                so = Int32.Parse(Console.ReadLine()); 
                if (so > 10) 
                {
                    Console.WriteLine("So khong duoc vuot qua 10");
                }
            }
            while (so > 10); 
          
            

            //nhap gia tri cho cac o trong mang
            mang = new int[so]; //khoi tao mang [mang] voi kich thuoc la [so]
            int i = 0; 
            while (i<mang.Length) //dung cau lenh vong lap while de nhap gia tri cho cac phan tu trong mang tu ban phim
            {
                Console.WriteLine("Nhap gia tri thu " + (i+1) + " : ");
                mang[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            
            //hien thi ra so da nhap tu ban phim
            Console.WriteLine("Cac gia tri da nhap: ");
            for (int j = 0; j < mang.Length; j++) //su dung cau lenh lap for de in cac gia tri trong mang ra man hinh
            {
                Console.Write(mang[j] + "  ");
            }
            Console.WriteLine();
            
            //tim so lon nhat va vi tri cua no trong mang
            int solonnhat = mang[0]; //tao bien solonnhat voi gia tri la phan tu dau tien cua mang [mang]
            int vitri = 1; //tao bien vitri voi gia tri 1
            for (int j = 0;j < mang.Length; j++) //dung lenh vong lap de duyet qua tung phan tu trong mang [mang]
            {
                if (mang[j] > solonnhat) //dung if kiem tra phan tu [mang] tai vi tri [J] co lon hon [solonnhat] hay khong
                { //neu thoa man dieu kien thuc hien luu solannhat = phan tru trong [mang] tai vi tri [j] va luu vitri = j + 1
                    solonnhat = mang[j]; 
                    vitri = j + 1;
                }

            }
            Console.WriteLine("Gia tri lon nhat trong danh sach mang la " + solonnhat + ", o vi tri " + vitri);

            Console.ReadKey();
        }
    }
}
