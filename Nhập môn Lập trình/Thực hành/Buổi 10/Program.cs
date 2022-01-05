using System;
using System.IO;
using System.Text;

namespace BaitapOn
{
    class Program
    {
        // Biến toàn cục
        static string[] lines;
        static string filePath = "../../../TextFile/DSSV.txt";

        static void Main(string[] args)
        {
            // Dùng thêm thư viện : using System.Text;
            // Xuất text theo Unicode (có dấu tiếng Việt)
            Console.OutputEncoding = Encoding.Unicode;
            // Nhập text theo Unicode (có dấu tiếng Việt)
            Console.InputEncoding = Encoding.Unicode;

            int chon = 0;
            do
            {
                chon = Menu();
                switch (chon)
                {
                    case 1: // Tạo Danh sách : file -> lines
                        {
                            Init();
                            Console.WriteLine(); break;
                        }
                    case 2: // Xem Danh Sách
                        {
                            ListView();
                            Console.WriteLine(); break;
                        }
                    case 3: // Tìm sinh viên theo mã sv
                        {
                            Console.Write(" Nhập Mã SV cần tìm :");
                            string masv = Console.ReadLine();
                            int vitri = Find(masv);
                            if (vitri > -1)
                            {
                                PrintTitle();
                                PrintOneLine(lines[vitri], vitri);
                            }
                            else
                                Console.WriteLine(" Không có sinh viên với mã sv : " + masv);
                            Console.WriteLine(); break;
                        }
                    case 4: // Cập nhật điểm
                        {
                            Console.Write(" Nhập Mã SV cần cập nhật :");
                            string masv = Console.ReadLine();
                            int vitri = Find(masv);
                            if (vitri > -1) // nếu có
                            {
                                PrintTitle();
                                PrintOneLine(lines[vitri], vitri); // xuất thông tin SV
                                Console.Write(" Nhập điểm mới :");
                                int diem = int.Parse(Console.ReadLine());
                                Update(vitri, diem);
                                PrintTitle();
                                PrintOneLine(lines[vitri], vitri); // xuất TT sau khi cập nhầt
                            }
                            else
                                Console.WriteLine(" Không có sinh viên với mã sv : " + masv);
                            Console.WriteLine(); break;
                        }
                    case 5:  // Thêm Sinh viên
                        {
                            AddNew();
                            Console.WriteLine(); break;
                        }
                    case 6:  // Xóa Sinh viên
                        {
                            Console.Write(" Nhập Mã SV cần xóa :");
                            string masv = Console.ReadLine();
                            // Tìm masv trong danh sách
                            int vitri = Find(masv);
                            if (vitri > -1) // nếu có
                            {
                                DeleteSV(vitri);
                                Console.WriteLine(" Xóa thành công");
                            }
                            else
                                Console.WriteLine(" Không có sinh viên với mã sv : " + masv);
                            Console.WriteLine(); break;
                        }
                    case 7:  // Cập nhật DS lines -> file
                        {
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine(); break;
                        }

                }
                //Console.WriteLine();
            } while (chon != 0);

            Console.WriteLine();
        }
        // Menu chương trình
        static int Menu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("             QUẢN LÝ DANH SÁCH SINH VIÊN");
            Console.WriteLine(" 1. Tạo Danh sách            2. Xem Danh sách");
            Console.WriteLine(" 3. Tìm Sinh viên            4. Cập nhật Điểm");
            Console.WriteLine(" 5. Thêm Sinh viên           6. Xóa Sinh viên");
            Console.WriteLine(" 7. Cập nhật Danh sách       8. ");
            Console.WriteLine(" 0. Thoát");
            Console.WriteLine(new string('-', 50));
            Console.Write(" Chon : "); int chon = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return chon;
        }
        // Khởi tạo DS : File -> lines
        static void Init()
        {
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
                Console.WriteLine(" Đã tạo xong Danh Sách");
            }
            else
                Console.WriteLine("Không tồn tại hồ sơ");
        }
        // Xem DS sinh viên
        static void ListView()
        {
            PrintTitle();  // Xuất tiêu đề
            // Xuất các dòng thông tin SV
            for (int i = 1; i < lines.Length; i++)
                PrintOneLine(lines[i], i);  // Xuất một dòng với số thứ tự i
            Console.WriteLine(new string('-', 85));
        }
        // Xuất tiêu đề của danh sách. lines[0] dòng chứa tiêu đề
        static void PrintTitle()
        {
            string[] s = lines[0].Split('\t');
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0, 50}", "DANH SÁCH SINH VIÊN");
            Console.WriteLine($"    Stt   {s[0],-12} {s[1],-20} {s[2],-12} {s[3],-12} {s[4],-6} {s[5],-10}");
            Console.WriteLine(new string('-', 85));
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Xuất 1 dòng (line) với số thứ tự là stt
        static void PrintOneLine(string line, int stt)
        {
            // Tách các thành phần trong line
            string[] s = line.Split('\t');
            Console.WriteLine($"   {stt,4}   {s[0],-12} {s[1],-20} {s[2],-12} {s[3],-12} {s[4],-6} {s[5],-10}");
        }
        // Tìm sinh viên theo mã sv, trả về vị trí tìm thấy, nếu không trả về -1
        static int Find(string ma)
        {
            for (int i = 1; i < lines.Length; i++)
                if (ma == lines[i].Substring(0, ma.Length))
                    return i;
            return -1;
        }
        // Thêm sinh viên
        static void AddNew()
        {
            // Nhập thông tin mới
            Console.WriteLine("  Thêm sinh viên mới");
            Console.Write("  Nhập mã SV : "); string ma = Console.ReadLine();
            Console.Write("    Họ _ Lót : "); string ho = Console.ReadLine();
            Console.Write("         Tên : "); string ten = Console.ReadLine();
            Console.Write("   Ngày sinh : "); string ns = Console.ReadLine();
            Console.Write("        Phái : "); string phai = Console.ReadLine();
            Console.Write("        Điểm : "); string diem = Console.ReadLine();
            // Cấp phát thêm vùng nhớ cho lines
            Array.Resize(ref lines, lines.Length + 1);
            // phần tử cuối được cấp thêm
            lines[lines.Length - 1] = ma + '\t' + ho + '\t' + ten + '\t' + ns + '\t' + phai + '\t' + diem;
            Console.WriteLine(" Đã thêm sinh viên mới vào Danh Sách");
        }
        // Xóa SV có số thứ tự vt -> xóa phần tử thứ vt trong array
        static void DeleteSV(int vt)
        {
            for (int i = vt; i < lines.Length - 1; i++)
                lines[i] = lines[i + 1];
            //cấp phát lại vùng nhớ cho lines
            Array.Resize(ref lines, lines.Length - 1);
            Console.WriteLine(" Đã xóa một sinh viên trong Danh Sách");
        }
        // Cập nhật điểm Sv có số thứ tự i với điểm mới là diem 
        static void Update(int i, int diem)
        {
            // Tách các thành phần dòng lines[i]
            string[] s = lines[i].Split('\t');
            // s[5] là cột diểm cần cập nhật điểm mới (diem)
            s[5] = diem.ToString();
            // Xây dựng lại nội dung dòng lines[i]
            lines[i] = s[0] + '\t' + s[1] + '\t' + s[2] + '\t' + s[3] + '\t' + s[4] + '\t' + s[5];
            Console.WriteLine(" Đã cập nhật điểm mới cho sinh viên");
        }
    }
}
