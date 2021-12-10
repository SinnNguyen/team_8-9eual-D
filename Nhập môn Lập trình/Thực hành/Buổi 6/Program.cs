
//**********************Bai1**********************

using System;

namespace Bai1
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("        ARRAY - KHOI TAO ARRAY");
            Console.WriteLine("  1. Xuat cac phan tu cua A len man hinh");
            Console.WriteLine("  2. Xuat cac phan tu cua A theo thu tu dao nguoc");
            Console.WriteLine("  3. Max/Min element in A[]");
            Console.WriteLine("  4. So chinh phuong trong A[]");
            Console.WriteLine("  5. Avg() in A[]");
            Console.WriteLine("  6. Seperate odd/even element in A[] into C[] and D[]");
            Console.WriteLine(new string('-', 120));
            Console.Write(" (Nhan 0 de Thoat)         Chon : ");
            int chon = int.Parse(Console.ReadLine());
            return chon;
        }
        static void XuatMang(int[] A, int N)
        {
            //Console.WriteLine();
            Console.Write("     Mang vua gan la: ");
            for (int i = 0; i < N; i++)
                Console.Write("{0} ", A[i]);
            Console.WriteLine();
        }
        static void DaoMang(int[] A, int N)
        {
            Console.Write("     Mang vua dao nguoc la: ");
            for (int i = N - 1; i >= 0; i -= 1)
                Console.Write("{0} ", A[i]);
            Console.WriteLine();
        }
        static int TimMax(int[] A, int N)
        {
            int max = A[0];
            for (int i = 0; i < N; i++)
            {
                if (A[i] > max)
                    max = A[i];
            }
            return max;
        }
        static int TimMin(int[] A, int N)
        {
            int min = A[0];
            for (int i = 0; i < N; i++)
            {
                if (A[i] < min)
                    min = A[i];
            }
            return min;
        }
        static void outSCP(int[] A, int N) 
        {

            static bool scp(int x)
            {
                int sqr = (int)Math.Sqrt(x);
                return (Math.Pow(sqr,2) == x);
            }    
            for(int i = 0; i < N; i++) 
            {
                if(scp(A[i])) 
                    Console.Write("{0} ", A[i]);
            }
        }
        static double TrungBinhCong(int[] A, int N)
        {
            double tong = 0.00; int Dodai = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0)
                {
                    tong += A[i];
                    Dodai++;
                }
            }
            return tong / Convert.ToDouble(Dodai);
        }
        static void ChiaMang(int[] A, int N)
        {
            int[] Le = new int[10];
            int[] Chan = new int[10];
            int h = 0;
            int u = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Chan[h] = A[i];
                    h++;
                }
                else
                {
                    Le[u] = A[i];
                    u++;
                }
            }
            Console.Write("     Cac phan tu chan la: ");
            for (int i = 0; i < h; i++)            
                Console.Write("{0} ", Chan[i]);            
            Console.WriteLine();
            Console.Write("     Cac phan tu le la  : ");
            for (int i = 0; i < u; i++)          
                Console.Write("{0} ", Le[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Assign Vars select & Arrs A[], B[] / KHONG DUOC XOA
            int chon = 1;
            int[] A = new int[100];
            int[] B = new int[] { 36, 24, 91, 48, 53, 13, 86, 75, 64, 21, 79, 39 };

            //Copy B[] into A[] / KHONG DUOC XOA
            for (int i = 0; i < B.Length; i++)
                A[i] = B[i];

            //Switch case de lam bai       
            do
            {
                chon = Menu();
                switch (chon)
                {
                    case 1: //Bai 2
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 120));
                            XuatMang(A, B.Length);
                        }
                        break;
                    case 2: //Bai 3
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 120));
                            DaoMang(A, B.Length);
                        }
                        break;
                    case 3: //Bai 4
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 120));
                            //Console.WriteLine();
                            Console.Write("     Max element of Arr[] = {0}", TimMax(A, B.Length));
                            Console.WriteLine();
                            Console.Write("     Max element of Arr[] = {0}", TimMin(A, B.Length));
                            Console.WriteLine();
                        }
                        break;
                    case 4: //Bai 5
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 120));
                            Console.Write("     So chinh phuong trong Arr[] = ");
                            outSCP(A, B.Length);
                            Console.WriteLine(); 
                        }
                        break;
                    case 5: //Bai 6
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 120));
                            Console.WriteLine("     Avg of elements in Arr[] = {0:0.00}", TrungBinhCong(A, B.Length));
                        }
                        break;
                    case 6: // Bai 7
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 120));
                            ChiaMang(A, B.Length);
                        }
                        break;
                }
            } while (chon > 0 && chon <= 6); //From 1 -> 6
        }
    }
}
//**********************Bai2**********************
/*
using System;

namespace Bai2
{
    class Program
    {
        private static int[] a;
        private static int n;

        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(" ARRAY – CAC THAO TAC TREN ARRAY");
            Console.WriteLine(" 1. Cau 1: Tron xen ke giua cac phan tu a1 va a2 vao a");
            Console.WriteLine(" 2. Cau 2: Tim cac phan tu giong nhau trong array a");
            Console.WriteLine(" 3. Cau 3: Xoa bot cac phan tu giong nhau trong array a");
            Console.WriteLine(new string('-', 120));
            Console.Write(" (Nhan 0 de Thoat) Chon : ");
            int chon = int.Parse(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            int chon;
            do
            {
                chon = Menu();
                switch (chon)
                {
                    case 1: { Cau1(); break; }
                    case 2: { Cau2(); break; }
                    case 3: { Cau3(a, ref n); break; }
                }

            } while (chon != 0);
        }
       
        static void Cau1()
        {
            double[] a = new double[100];
            double[] b = new double[100];
            double[] a1 = { 91, 53, 13, 75, 21, 79, 39 };
            double[] a2 = { 36, 24, 48, 86, 64 };
            int ia = 0, ib = 0, nc = 0, i, j;
            while (ia < a1.Length && ib < a2.Length)
            {
                a[nc++] = a1[ia++];
                a[nc++] = a2[ib++];
            }
            while (ia < a1.Length)
                a[nc++] = a1[ia++];
            while (ib < a2.Length)
                a[nc++] = a2[ib++];
            Console.Write("Mang a khi sap xep xen ke duoc la: ");
            for (i = 0; i < a1.Length + a2.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Cau2()
        {
            int[] a = new int[100];
            Console.Write("Nhap so phan tu a: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("Cac so lap lai trong day a la: ");
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] == a[i + 1])
                    Console.Write(a[i] + " ");
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Cau3(int[] a, ref int n)
        {
            Console.WriteLine("Cau3:");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("So phan tu da loai bo cac so lap:");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        i++;
                    }
                }
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
*/        
    