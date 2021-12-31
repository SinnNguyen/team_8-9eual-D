using System;
using System.IO;
using System.Text;

namespace Buoi_9
{
    internal class Program
    {

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine(new string('*', 60));
            Console.WriteLine("                 MENU BUOI 9");
            Console.WriteLine();
            Console.Write(" 1. Dem ky tu.         "); Console.Write(" 2. Kiem tra password.");
            Console.WriteLine();
            Console.Write(" 3. Tach ho ten.       "); Console.Write(" 4. Robot Dong - Tay - Nam - Bac");
            Console.WriteLine();
            Console.Write(" 5. Cong 2 int lon.    "); Console.Write(" 6. DSSV.");
            Console.WriteLine();
            Console.Write("0. Thoat."); Console.WriteLine();
            Console.WriteLine(new string('=', 60));
            Console.WriteLine();
            Console.Write("     Nhap lua chon: "); int x = int.Parse(Console.ReadLine());
            return x;
        }
        static void DemKyTu(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                int[] count = new int[26];
                for (int i = 0; i < 26; i++)
                    count[i] = 0;
                string s = lines[0].ToUpper();

                for (int i = 0; i < s.Length; i++)
                    if (s[i] >= 65 && s[i] <= 90)
                        count[s[i] - 65]++;

                lines[0] = ""; int nhieunhat = -int.MaxValue; char c = ' ';
                for (int i = 0; i < count.Length; i++)
                    if (count[i] > 0)
                    {
                        lines[0] = lines[0] + (char)(i + 65) + " : " + count[i] + "\n";
                        if (count[i] > nhieunhat)
                            nhieunhat = count[i]; c = (char)(i + 65);
                    }
                lines[0] = lines[0] + "First Max Freq : " + c + " , " + nhieunhat;

                File.WriteAllLines("../../../TextFile/Output.txt", lines);
            }
            else
                Console.WriteLine("     Khong tim thay file");
        }
        static void check_pass(string filePath)
        {
            static void count_char(char[] c, out int x, out int y, out int z)
            {
                x = 0; y = 0; z = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] >= (char)48 && c[i] <= (char)57)
                        x++;
                    if (c[i] >= (char)65 && c[i] <= (char)90)
                        y++;
                    if (c[i] >= (char)97 && c[i] <= (char)122)
                        z++;
                }
            }
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length < 8)
                    {
                        lines[i] += " No";
                        File.WriteAllLines("../../../TextFile/PasswordValidation.txt", lines);
                    }
                    else
                    {
                        int so = 0, hoa = 0, thuong = 0;

                        char[] c = lines[i].ToCharArray();
                        count_char(c, out so, out hoa, out thuong);

                        if (so > 0 && thuong > 0 && hoa > 0)
                        {
                            lines[i] += " Yes";
                            File.WriteAllLines("../../../TextFile/PasswordValidation.txt", lines);
                        }
                        else
                        {
                            lines[i] += " No";
                            File.WriteAllLines("../../../TextFile/PasswordValidation.txt", lines);
                        }
                    }
                }
            }
            else
                Console.WriteLine("     Khong tim thay file!");
        }
        static void tach_ho_ten(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] s = lines[i].Split();
                    string holot = "";
                    for (int j = 1; j < s.Length - 1; j++)
                        holot = holot + s[j] + " ";
                    lines[i] = lines[i] + "\n - Ho : " + s[0] + "\n - Ho Lot : " + holot + "\n - Ten : " + s[s.Length - 1];
                }
                File.WriteAllLines("../../../TextFile/SplitNames.txt", lines);
            }
            else
                Console.WriteLine("     Khong tim thay file!");
        }
        static void RobotDTNB(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string[] s = lines[0].Split();
                int X = int.Parse(s[0]); int Y = int.Parse(s[1]);
                string[] move = new string[lines[1].Length + 1];
                move[0] = lines[0];
                Console.WriteLine("       Begin : " + move[0]);
                for (int i = 0; i < lines[1].Length; i++)
                {

                    switch (lines[1][i])
                    {
                        case 'B': { Y = Y + 1; break; }
                        case 'D': { X = X + 1; break; }
                        case 'N': { Y = Y - 1; break; }
                        case 'T': { X = X - 1; break; }
                    }
                    move[i + 1] = X.ToString() + " " + Y.ToString();
                    Console.WriteLine($"Step {i + 1}  {lines[1][i]}  :  {move[i + 1]}");
                }
                File.WriteAllLines("../../../TextFile/Moves.txt", move);
            }
            else
                Console.WriteLine(" Khong tim thay file");      
        }
        static string CongHaiSoNguyenLon(string x, string y)
        {
            int len = x.Length > y.Length ? x.Length : y.Length;
            string kq = "";
            if (x.Length < len)
                x = "0" + x;
            if (y.Length < len)
                y = "0" + y;
            int nho = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                int cong = int.Parse(x[i].ToString()) + int.Parse(y[i].ToString()) + nho;
                kq = (cong % 10).ToString() + kq;
                nho = cong / 10;
            }
            Console.WriteLine("Ket qua = " + kq);
            return kq;
        }
        static void DSSV(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.Clear();

                static int MenuDSSV()
                {
                    Console.WriteLine("     CHUONG TRINH QUAN LY SINH VIEN");
                    Console.Write(" 1. Tim kiem sinh vien       2. Thong ke sinh vien");
                    Console.WriteLine();
                    Console.WriteLine(" 3. Them sinh vien");
                    Console.WriteLine();
                    Console.Write("Nhap lua chon: "); int x = int.Parse(Console.ReadLine()); 
                    return x;  
                }

                static void outInfo(string[] A)
                {

                    for (int i = 1; i < A.Length - 1; i++)
                    {
                        string[] process = A[i].Split('\t');                      
                        Console.WriteLine("{0,-9} {1,-20} {2,-6} {3,12} {4,5}", process[0], process[1], process[2], process[3], process[4]);
                    }
                    Console.WriteLine();
                }    
                static void TimMaSV(string[] A)
                {
                    Console.WriteLine();

                    string[] MSSV = new string[10];
                    Console.Write("  Nhap MSSV can tim: "); 
                    string x = Console.ReadLine();

                    Console.WriteLine();

                    for (int i = 1; i < A.Length - 1; i++)
                    {
                        string[] process = A[i].Split('\t');
                        if (x == process[0])
                            Console.WriteLine("{0,-9} {1,-20} {2,-6} {3,12} {4,5}", process[0], process[1], process[2], process[3], process[4]);                        
                    }                         
                }
                static void ThongKe(string[] A)
                {
                    Console.WriteLine();
                    int dem_nam = 0, dem_nu = 0, tong = 0;
                    for (int i = 1; i < A.Length - 1; i++)
                    {
                        string[] process = A[i].Split('\t');
                        tong++;
                        if(process[4]  == "Nam")
                            dem_nam++;
                        if (process[4] == "Nữ")
                            dem_nu++;
                    }
                    Console.WriteLine(" Thong ke: ");
                    Console.Write("  SV Nam: {0,-3} | SV Nu: {1,-3} | Tong: {2,-3}", dem_nam, dem_nu, tong);
                }
                static void AddSV(string[] A, string filePath)
                {
                    int dem = 0;
                    for (int i = 1; i < A.Length - 1; i++)
                        dem++;

                    Console.Write(" Nhap MSSV: ");
                    string MSSV = Console.ReadLine();
                    Console.Write(" Nhap Ho + Ho lot SV: ");
                    string Ho = Console.ReadLine();
                    Console.Write(" Nhap Ten SV: ");
                    string Ten = Console.ReadLine();
                    Console.Write(" Nhap gioi tinh (Nam/Nu): ");
                    string Gender = Console.ReadLine();

                    string process = MSSV + "\t" + Ho + "\t" + Ten + "\t" + Gender;

                    Array.Resize(ref A, A.Length + 1);
                    A[dem++] = process;
                    File.WriteAllLines(filePath, A);
                }
                string[] lines = File.ReadAllLines(filePath);       
                string[] title = lines[0].Split('\t');
                string[] info = new string[lines.Length - 1]; 

                Console.WriteLine("{0,-9} {1,-20} {2,-6} {3,12} {4,5}", title[0], title[1], title[2], title[3], title[4]);
                Console.WriteLine(new string('-', 60));

                outInfo(lines);

                Console.WriteLine(info[0]);

                int chon = MenuDSSV();
                switch (chon)
                {
                    case 1:
                        {
                            TimMaSV(lines); 
                        }
                        break;
                    case 2:
                        {
                            ThongKe(lines);
                        }
                        break;
                    case 3:
                        {
                            AddSV(lines, filePath);
                        }
                        break;
                }
            }
            else
                Console.WriteLine("     Khong tim thay file!"); 
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            int chon = Menu();
            switch (chon)
            {
                case 1:
                    {
                        string filePath = "../../../TextFile/Input.txt";
                        DemKyTu(filePath);
                    }
                    break;
                case 2:
                    {
                        string filePath = "../../../TextFile/Password.txt";
                        check_pass(filePath);
                    }
                    break;
                case 3:
                    {
                        string filePath = "../../../TextFile/Names.txt";
                        tach_ho_ten(filePath);
                    }
                    break;
                case 4:
                    {
                        string filePath = "../../../TextFile/Direction.Txt";
                        RobotDTNB(filePath);
                    }
                    break;
                case 5:
                    {
                        Console.Write("Nhap chuoi x = "); string x = Console.ReadLine();
                        Console.Write("Nhap chuoi y = "); string y = Console.ReadLine();
                        //Console.WriteLine("Ket qua = {0}",CongHaiSoNguyenLon(x,y));
                        CongHaiSoNguyenLon(x, y);
                    } 
                    break;
                case 6:
                    {
                        string filePath = "../../../TextFile/DSSV.txt";
                        DSSV(filePath);
                    }
                    break;
                default:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
