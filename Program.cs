using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course(1,10);
            Course course2 = new Course(2,10);
            Course course3 = new Course(2,10);

            DangKyHocPhan dkhp = new DangKyHocPhan();

            if(dkhp.DangKy(18120585, 1)) { 
                Console.WriteLine("18120585 dang ki thanh cong!");
            }
            else { 
                Console.WriteLine("18120585 dang ki that bai");
            }
             
            Console.WriteLine("Done!");
        }
    }
}
