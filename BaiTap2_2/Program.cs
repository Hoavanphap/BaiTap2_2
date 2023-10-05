using System;
namespace Bai2_2
{
    class BaiTapVeNha
    {
        static void Main(string[] args)
        {
            int x, hour, min, sec;
            Console.WriteLine("Nhap vao so giay muon quy doi:");
            x = Convert.ToInt32(Console.ReadLine());
            hour = x / 3600;
            min = (x % 3600) / 60;
            sec = x - (hour * 3600) - (min * 60);
            Console.WriteLine("So giay sau khi quy doi: {0:00}:{1:00}:{2:00}", hour, min, sec);
            Console.ReadKey();
        }

    }
}