using System;

namespace Buoi4
{
    class Program
    {
        static void Bai1()
        {
            Console.Write("Nhap x= "); int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y = "); int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            int s = 0;
            for (int i = x + 1; i < y; i++)
                if (i % 2 != 0)
                    s += i;
            Console.WriteLine($"Tong = {s} ");
        }
        static void Bai2()
        {
            Console.Write("Nhap n ="); int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i += 2)
                Console.Write($"{ i * i,4}");
        }
        static void Bai3()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    s += i;
            if (s == n)
                Console.WriteLine($"{n} la so hoan hao");
            else
                Console.WriteLine($"{n} khong la so hoan hao");
        }
        static void Bai4_Mau01()
        {
            {
                Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void Bai4_Mau02()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                    Console.Write("{0}, j ");
                Console.WriteLine();
            }
        }
        static void Bai4_Mau03()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                for (int j = n - 1; j >= i; j--)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void Bai4_Mau04()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    if (j == 1 || j == i)
                        Console.Write("* ");
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }
            for (int j = 1; j <= n; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
        static void Bai4_Mau05()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
        }
        static void Bai4_Mau06()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{++dem} ");
                Console.WriteLine();
            }
        }
        static void Bai4_Mau07()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
        }
       static void Bai4_Mau08()
        {
            Console.Write("Nhap n = "); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    if (j == 1 || j == i)
                        Console.Write("{0} ", j);
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }
            for (int j = 1; j <= n; j++)
                Console.Write("{0} ", j);
            Console.WriteLine();
        }
        static void Bai5()
        {
            int chon = 1;
            do
            {
                Console.Write("Enter the PRODUCT'S CODE: ");
                int pCode = int.Parse(Console.ReadLine());

                Console.Write("Enter the PRODUCT'S QUANTITY: ");
                int pQuantity = int.Parse(Console.ReadLine());

                string pName = ""; double price = 0;

                switch (pCode)
                {
                    case 1:
                        {
                            pName = "Cochorro Quente";
                            price = 4;
                        }
                        break;
                    case 2:
                        {
                            pName = "X-Salada";
                            price = 4.5;
                        }
                        break;
                    case 3:
                        {
                            pName = "X-Bacon";
                            price = 5;
                        }
                        break;
                    case 4:
                        {
                            pName = "Torrada simples";
                            price = 2;
                        }
                        break;
                    case 5:
                        {
                            pName = "Refrigerante";
                            price = 1;
                        }
                        break;
                    default:
                        {
                            chon = 0;
                            Console.WriteLine("Da xay ra loi... Vui long khoi dong lai ung dung!");
                            System.Environment.Exit(1);
                        }
                        break;
                }

                double total = price * pQuantity;

                Console.WriteLine();

                Console.WriteLine("{0,-20} | {1,12} | {2,12} | {3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
                Console.WriteLine("{0,-20} | {1,12:0.00} | {2,12} | {3,12:0.00}", pName, price, pQuantity, total);
                              
                Console.WriteLine();

                Console.Write("Tiep tuc (1/0): "); chon = int.Parse(Console.ReadLine());

                Console.WriteLine();
            } while (chon != 0);
        }
        static void Bai6()
        {
            Console.Write("Nhap 1 so de kiem tra: "); int N = int.Parse(Console.ReadLine());
            bool ans = true;
            for (int i = 1; i <= N; i++)
            {
                if (Math.Pow(i, 2) == N)
                {
                    ans = true;
                    break;
                }
                else ans = false;
            }
            if (ans == true)
                Console.WriteLine("{0} la so chinh phuong.", N);
            else
                Console.WriteLine("{0} khong la so chinh phuong!", N);        
        }
        static void Bai7()
        {
            Console.Write("Nhap so N: "); int N = int.Parse(Console.ReadLine());
            int k = 0, S = 0;

            while (S < N)
            {
                k++;
                S += k;
                if (S == N || S > N)
                {
                    S -= k;
                    break;
                }      
            }

            Console.WriteLine("Tong S < N = {0}", S);
        }
        static void Bai8()
        {
            static int UCLN(int a, int b)
            {
                if (b == 0) return a;
                return UCLN(b, a % b);
            }
            Console.Write("Nhap so nguyen duong a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen duong b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("UCLN cua {0} va {1} la: {2} ", a, b, UCLN(a, b));
        }
        static void Bai9()
        {
            static int UCLN(int x, int y)
            {
                if (y == 0) 
                    return x;
                return UCLN(y, x % y);
            }
            Console.Write("Nhap so thu 1: ");
            int a = int.Parse(Console.ReadLine());            
            Console.Write("Nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Boi chung nho nhat cua {0} va {1} = {2}", a, b, a * b / UCLN(a,b));
        }

        static void Bai10()
        {
            static bool checkSNT(int x)
            {
                if (x < 2)
                {
                    return false;
                }
                double sqrt1 = Math.Sqrt(x);
                for (int i = 2; i <= sqrt1; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.Write("Nhap so N: "); int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (N >= 2)
            {
                Console.WriteLine("Cac SNT < {0} la: ", N);
                Console.Write("{0} ", 2);
                for (int i = 3; i < N; i += 2)
                {
                    if (checkSNT(i) == true)
                        Console.Write("{0} ", i);
                }
            }
            else
                Console.WriteLine("Khong co So nguyen to! ");                       
        }
        static void Main(string[] args)
        {
            //Bai1();

            //Bai2();

            //Bai3();

            //Bai4_Mau01();

            //Bai4_Mau02();

            //Bai4_Mau03();

            //Bai4_Mau04();

            //Bai4_Mau05();

            //Bai4_Mau06();

            //Bai4_Mau07();

            //Bai4_Mau08();

            Bai5(); //ok

            //Bai6(); //ok

            //Bai7(); //ok 

            //Bai8();

            //Bai9(); //ok

            //Bai10();
        }
    }
}