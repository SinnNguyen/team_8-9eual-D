using System;
using System.IO;

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
            Console.Write(" 1. Dem ky tu         "); Console.Write("2. Kiem tra password");
            Console.WriteLine();
            Console.Write(" 3. Tach ho ten       "); Console.Write("4. Robot Dong - Tay - Nam - Bac");
            Console.WriteLine();
            Console.Write(" 5. Cong 2 int lon    "); Console.Write("0. Thoat"); Console.WriteLine();
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
            {
                Console.WriteLine(" Khong tim thay file");
            }
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
            Console.WriteLine($"ket qua : {kq}");
            return kq;
        }
        static void Main(string[] args)
        {
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
                        ;
                    }
                    break;
                case 3:
                    {
                        ;
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
                        CongHaiSoNguyenLon(x, y);
                    }
                    break;
                default:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
