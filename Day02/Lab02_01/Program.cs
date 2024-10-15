﻿/// <summary>
/// Chuong trinh minh hoa việc nhập xuất trong ứng dung console 
/// Nhap vào mã sinh vién, tên sinh viên, ngay sinh va điểm 3 môn 
/// In ra thông tin sinh viên va điểm trung binh
/// </summary>

/// <param name="args"></param>
static void Main(string[] args)
{
    //Khai báo các biến
    string id, name;
    double mark1, mark2, mark3, average;
    DateTime birthday;
    //nhập dữ liệu từ bàn phím
    Console.WriteLine("Nhap ma so:");
    id = Console.ReadLine();
    Console.WriteLine("Nhap ten:");
    name = Console.ReadLine();
    Console.WriteLine("Nhap ngay sinh:");
    birthday = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine("Nhap diem mon 1:");
    mark1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Nhap diem mon 2:");
    mark2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Nhap diem mon 3:");
    mark3 = Convert.ToDouble(Console.ReadLine());
    //Tính điểm trung bình
    average = (mark1 + mark2 + mark3) / 3;
    //In thông tin ra màn hình
    Console.WriteLine("\n Thong tin sinh vien");
    Console.WriteLine("Ma so:{0}", id);
    Console.WriteLine("Ho va ten:{0}", name);
    Console.WriteLine("Ngay sinh:{0:đ/MM/yyyy}", birthday);
    Console.WriteLine("Diem 1:{0:N}, Diem 2:{1:N}, Diem 3:{2:N}", mark1, mark2, mark3);
    Console.WriteLine("Diem trung binh:{0:N}", average);
}