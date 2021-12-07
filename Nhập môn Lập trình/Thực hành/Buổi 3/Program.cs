using System;

namespace Buoi03
{
    class Program
    {
        static void Bai1()
        {
            Console.Write("Nhap so nguyen duong N: ");
            int N = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= N)
            {
                Console.Write("{0} ", i);
                i++;
            }
        }
        static void Bai2()
        {
            Console.Write("Nhap so nguyen duong N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                if (i % 2 != 0)
                    Console.Write("{0} ", i);
            }
        }
        static void Bai3()
        {
            static void inputInt(out int m)
            {
                do
                {
                    Console.Write("Nhap lai 1 so > 1: ");
                    m = int.Parse(Console.ReadLine());
                } while (m <= 1);
            }

            Console.Write("Nhap 1 so > 1: ");
            int n = int.Parse(Console.ReadLine());

            do
            {
                if (n < 1)
                {
                    inputInt(out n);
                }

            } while (n < 1);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }

            }
        }
        static void Bai4()
        {
            Console.Write("Nhap so nguyen N: ");
            int N = int.Parse(Console.ReadLine());

            double S = 0;
            double Avg = 0;

            for (int i = 1; i <= N; i++)
            {
                S += i;
                Avg = S / i;
            }

            Console.WriteLine();
            Console.WriteLine("Sum = {0}, Avg = {1}", S, Avg);
        }
        static void Bai5()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write("{0} ", i);
            }
        }
        static void Bai6()
        {           
            static bool checkSNT(int x) 
            {
                int y = 0;

                for (int i = 1; i <= x; i++)
                    if (x % i == 0)
                        y++;

                    if (y == 2)
                        return true;
                    else
                        return false;
            }
            Console.Write("Nhap so can ktra: ");
            int N = int.Parse(Console.ReadLine());

            if (checkSNT(N) == true) 
                Console.WriteLine("{0} la so nguyen to.", N);
            else 
                Console.WriteLine("{0} khong la so nguyen to!", N);
        
        }
        static void Bai7()
        {
            int S = 0;

            for (int i = 1; i < 200000; i++)
            {
                S++;
            }

            Console.WriteLine("{0}", S);
        }
        static void Bai8()
        {
            Console.Write("Nhap so nguyen N: ");
            int N = int.Parse(Console.ReadLine());

            int S = 0;

            for (int i = 1; i < N; i++)
            {
                S++;
            }
            Console.WriteLine("{0}", S);
        }
        static void Bai9()
        {
            Console.Write("Nhap so N: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 100 || n > 500)
            {
                Console.WriteLine("Nhap sai..Hay nhap lai");
                Console.Write("Nhap so N: ");
                n = int.Parse(Console.ReadLine());
            }

            while (n % 2 != 0)
            {
                Console.WriteLine("Nhap sai..Hay nhap lai");
                Console.Write("Nhap so N: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0} thuoc khoang [100,500] va chia het cho 2", n);
        }
        static void Bai10()
        {
            Console.Write("Nhap 1 so nguyen: ");
            int N = int.Parse(Console.ReadLine());

            int giai_thua = 1;

            for (int i = 1; i <= N; i++)
                giai_thua *= i;

            Console.WriteLine("{0}! = {1}", N, giai_thua);
        }
        static void Bai11()
        {
            Console.Write("Nhap 1 so nguyen: ");
            int N = int.Parse(Console.ReadLine());

            double S = 0;

            for (int i = 1; i <= N; i++)
            {
                S += 1.0 / i;
            }

            Console.Write("{0:0.00}", S);
        }
        static void Bai12()
        {
            double S = 0;

            for (int i = 0; i <= 19; i++)
            {
                S += (2.0 * i + 1) / (Math.Pow(2, i));
            }
            Console.WriteLine("S = {0:0.0000}", S);
        } 
        static void Bai13()
        {
            Console.Write("Nhap so N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= N; j++)
                {
                    if ((j * i) < 10)
                        Console.Write(" {0} x{1}{2} = {3}    |", j, "  ", i, j * i);
                    else
                    {
                        if (i != 10)
                        {
                            Console.Write(" {0} x{1}{2} = {3}   |", j, "  ", i, j * i);
                        }
                        else
                            Console.Write(" {0} x{1}{2} = {3}   |", j, " ", i, j * i);
                    }
                }
            }
        }
        static void Bai14()
        {
            Console.Write("Nhap so N: ");
            int N = int.Parse(Console.ReadLine());

            int b = 0;
            int a = 0;
            int c = N;

            while (N >= 10)
            {
                b = N / 10;
                a += 3 * b;
                N = (N - (10 * b)) + a;
            }
            Console.WriteLine();

            Console.WriteLine("Tong so chai Bo co the uong la: {0} ", c + a);
        }
        static void Bai15()
        {
            static bool checkSHH(ref int x)
            {
                int S = 0;
                for (int k = 1; k < x; k++)
                {
                    if (x % k == 0)
                    {
                        S += k; 
                    }
                }
                
                if (S == x)
                    return true;
                return false;
            }

            Console.Write("Nhap N: "); int N = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            if (checkSHH(ref N) == true)
                Console.WriteLine("{0} la so hoan hao. ", N);
            else
                Console.WriteLine("{0} khong la so hoan hao! ", N);   
        }
        static void Main(string[] args)
        {
            //Bai1();

            //Bai2();

            //Bai3(); 

            //Bai4();

            //Bai5();

            Bai6();

            //Bai7();  

            //Bai8();

            //Bai9();

            //Bai10();

            //Bai11();

            //Bai12(); 

            //Bai13(); 

            //Bai14();

            //Bai15(); 
        }
    }
}
