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

                    }
                    break;
                case 3:
                    {
                        
                    }
                    break;
                case 4:
                    {
                       
                    }
                    break;
                case 5:
                    {
                        
                    }
                    break;
                default:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
