using System;

namespace Buoi07
{
    class Program
    {
        // Bài 1 : InterchangeSort
        static void InterchangeSort(int[] a, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if(a[i] > a[j])
                    {
                        Swap(ref a[i],ref a[j]);
                    }
                }
            }
        }

        //Bài 2 : BubbleSort
        static void BubbleSort(int[] a, int n)
        {
            for(int i = 0; i < n-1; i++)
            {
                for(int j = n - 1; j > i; j--)
                {
                    if (a[j] < a[j - 1])
                        Swap(ref a[j], ref a[j - 1]);
                }
            }
        }

        // Hoán vị 2 phần tử x, y
        static void Swap(ref int x, ref int y)
        {

            int tmp = x; x = y; y = tmp;

        }

        // Tạo dãy ngẫu nhiên
        static void RandomArray(int[] a, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rd.Next(1, 100);
            Console.WriteLine();
        }

        //Xuất dãy
        static void PrintArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(" " + a[i]);
            Console.WriteLine("");
        }

        // Bài 3 : sắp xếp dãy tăng dần trong đoạn (left, right)
        static void Bai03(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }

        // Bai 4 : tìm phần tử lớn thứ k
        static int Bai04(int[] a , int n, int k)
        {
            int ak;
            InterchangeSort(a, n);
            return ak = a[k];
        }
        
        // Bai 5 : tìm phần tử chẳn trong dãy số nguyên a(n)
        static void Bai05(int[] a,int n)
        {
            Console.Write("Chan la: ");
            for(int i = 0; i< n;i++)
            {
                if(a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " " );
                }
            }
        }
        
        // Bai 6 : Hãy cho biết trong dãy 𝑎 có tồn tại cặp chỉ số 𝑖, 𝑗 mà 𝑖 < 𝑗 và 𝑎𝑖 + 𝑎𝑗 = 0 ?
        static bool Bai06(int[] a, int n)
        {
            for(int i = 0; i < n - 1;i++)
            {
               for(int j = i + 1; j < n; j++)
                {
                    if (a[i] + a[j] == 0)
                        return true;
                }
            }
                    return false;
        }

        // Bài 7 : Trộn 2 dãy a, b tăng dần thành dãy c tăng dần
        static void Bai07(int[] a, int n)
        {
            int bla = 0;
            int i;
            int j;
            int k;
            for (i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] c = new int[100];
            Console.Write(" Nhap so phan tu n cua c[] = ");
            int m = int.Parse(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                Console.Write("c[" + i + "] = ");
                c[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("day a: "); PrintArray(a, n);
            Console.Write("day c: "); PrintArray(c, m);
            int[] meta = new int[200];
            for (i = 0; i < n; i++)
            {
                meta[bla++] = a[i];
            }
            for (j = 0; j < m; j++)
            {
                meta[bla++] = c[j];
            }
            for (i = 0; i < bla; i++)
            {
                for (k = 0; k < bla - 1; k++)
                {
                    if (meta[k] >= meta[k + 1])
                    {
                        j = meta[k + 1];
                        meta[k + 1] = meta[k];
                        meta[k] = j;
                    }
                }
            }
            for (i = 0; i < bla; i++)
            {
                Console.Write("{0} ", meta[i]);
            }
        }

        // Bài 8 : Sắp xếp các phần tử vị trí lẻ tăng dần, các phần tử vị trí chẳn giảm dần
        static void Bai08(int[] a, int n)
        {
            int i;
            int j;
            int lastChan;
            int lastLe;
            for (i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            if (n % 2 == 0)
            {
                lastChan = n - 2;
                lastLe = n - 1;
            }
            else
            {
                lastChan = n - 1;
                lastLe = n - 2;
            }
            for (i = 0; i < lastChan; i += 2)
            {
                for (j = i + 2; j <= lastChan; j += 2)
                {
                    if (a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
            for (i = 1; i < lastLe; i += 2)
            {
                for (j = i + 2; j <= lastLe; j += 2)
                {
                    if (a[i] < a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }

        }

        // Bai 9 : BubbleSort2
        static void BubbleSort2(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j] > a[j - 1])
                        Swap(ref a[j], ref a[j - 1]);
                }
            }
        }
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine("SAP XEP & TIM KIEM TREN DAY");
            Console.WriteLine(" 1. Tao day a 2. Xuat dãy");
            Console.WriteLine(" 3. InterChangSort 4. BubbleSort");
            Console.WriteLine(" 5. Bai 3   6. Bai 4    7. Bai 5    8. Bai 6");
            Console.WriteLine(" 9. Bai 7   10. Bai 8   11. Bai 9 : BubbleSort2");
            Console.WriteLine(" 0. Thoat");
            Console.Write(" Chon : "); int chon = int.Parse(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5000];
            Console.Write(" Nhap so phan tu n cua a[]= ");
            int n = int.Parse(Console.ReadLine());
            int chon = 0;
            do
            {
                chon = Menu();
                switch (chon)
                {
                    case 1:
                        {
                            RandomArray(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                    case 2:
                        {
                            Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                    case 3:
                        {
                            RandomArray(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n);
                            InterchangeSort(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                    case 4:
                        {
                            RandomArray(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n);
                            BubbleSort(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                    case 5:
                        {
                            RandomArray(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n);
                            Bai03(a, n); Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                    case 6:
                        {
                            RandomArray(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n);
                            Console.Write(" Nhap k = "); int k = int.Parse(Console.ReadLine());
                            int ak = Bai04(a, n, k); Console.Write(" Day a: "); PrintArray(a, n);
                            Console.WriteLine(" Phan tu lon thu {0} trong day : " + ak,k); break;
                        }
                    case 7:
                        { 
                            Console.Write(" Day a: "); PrintArray(a, n);
                            Bai05(a,n); break; 
                        }
                    case 8:
                        {
                            Console.Write(" Day a: "); PrintArray(a, n);
                            if (Bai06(a, n) == true) Console.WriteLine("Ton tai");
                            else Console.WriteLine("Khong ton tai"); break;
                        }
                    case 9:
                        { Bai07(a,n); break; }
                    case 10:
                        {
                            Bai08(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                    case 11:
                        {
                            RandomArray(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n);
                            BubbleSort2(a, n);
                            Console.Write(" Day a: "); PrintArray(a, n); break;
                        }
                }
                Console.WriteLine();
            } while (chon != 0);
        }
    }
}

