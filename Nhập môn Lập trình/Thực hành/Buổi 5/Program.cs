using System; 

namespace Buoi5
{
    class Program
    {
        static void Bai01()
        {
            static void pToan(char p, int x, int y)
            {
                    int tong, hieu, tich; double thuong = 0.00;
                    switch(p)
                    {
                        case '+': 
                        {
                            tong = x + y;
                            Console.WriteLine(" Tong cua {0} va {1} = {2}", x, y, tong);
                        } break;
                    case '-':
                        {
                            hieu = x - y;
                            Console.WriteLine(" Hieu cua {0} va {1} = {2}", x, y, hieu);
                        } break;
                    case '*':
                        {
                            tich = x * y;
                            Console.WriteLine(" Tich cua {0} va {1} = {2}", x, y, tich);
                        }
                        break;
                    case '/':
                        {
                            if (y == 0)
                            {
                                Console.WriteLine("Phep chia giua {0} va {1} khong hop le!", x, y);
                            } 
                            else
                            {
                                thuong = Convert.ToDouble(x) / Convert.ToDouble(y);
                                Console.WriteLine(" Thuong cua {0} va {1} = {2:0.00}", x, y, thuong);
                            }                          
                        }
                        break;
                    }
            }
            Console.Write("Nhap so nguyen thu 1: "); 
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu 2: "); 
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nhap phep toan: "); 
            char pt = char.Parse(Console.ReadLine());

            Console.WriteLine();
            
            pToan(pt, a, b);          
        }
        static void Bai02()
        {
            static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            Console.Write("Nhap so a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b= "); int b = int.Parse(Console.ReadLine());
            Swap(ref a, ref b);
            Console.WriteLine($"Ket qua sau khi hoan doi a={a}, b={b}");
        }
        static void Bai03()
        {
            static double TinhToan(char p, int x, int y)
            {
                double ans = 0; 
                switch(p)
                {
                    case '+':
                        {
                            ans = x + y;
                        } break;
                    case '-':
                        {
                            ans = x - y;
                        }
                        break;
                    case '*':
                        {
                            ans = x * y;
                        }
                        break;
                    case '/':
                        {
                            ans = Convert.ToDouble(x) / Convert.ToDouble(y);
                        }
                        break;                    
                }
                return ans;
            }
            Console.Write("Nhap so nguyen thu 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nhap phep toan: ");
            char pt = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} = {3}", a, pt, b, TinhToan(pt,a,b));
        }
        static void Bai04()
        {
            static void TimMin(int a, int b, int c, out int min)
            {
                min = a;
                if (b < min) min = b;
                if (c < min) min = c;
            }
            Console.Write("Nhap so a= "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b= "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c= "); int c = int.Parse(Console.ReadLine());
            int min;
            TimMin(a, b, c, out min);
            Console.WriteLine($"So nho nhat trong {a}, {b}, {c} la= {min}");
        }
        static void Bai05()
        {
            static int timMax(ref int x, ref int y, ref int z)
            {
                int tmp = x;
                if (y > tmp)
                    tmp = y;
                if (z > tmp) 
                    tmp = z;
                return tmp;
            }
            Console.Write("Nhap so thu 1: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 3: "); int c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("   Max({0},{1},{2}) = {3}", a, b, c, timMax(ref a, ref b, ref c));
        }
        static void Bai06()
        {
            static void TimMinMax(int a, int b, int c, out int min, out int max)
            {
                max = a;
                if (b > max) max = b;
                if (c > max) max = c;
                min = a;
                if (b < min) min = b;
                if (c < min) min = c;

            }
            int min, max;
            Console.Write("Nhap a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c= ");
            int c = int.Parse(Console.ReadLine());
            TimMinMax(a, b, c, out min, out max);
            Console.WriteLine($"Max({a}, {b}, {c}) = {max}");
            Console.WriteLine($"Min({a}, {b}, {c}) = {min}");
            Console.ReadLine();
        }
        static void Bai07()
        {
            static int tongN(int x)
            {
                int tong = 0;
                for (int k = 0; k <= x; k++)
                    tong += k;
                return tong;
            }
            Console.Write("Nhap so N: "); int N = int.Parse(Console.ReadLine());
            Console.WriteLine(); // 1 2 3 4 5 6 = 21
            Console.WriteLine(" Tong tu 1 toi {0} = {1}", N, tongN(N));
        }
        static void Bai08()
        {
            static int TongChuSo(int n)
            {
                int sum = 0;
                while (n != 0)
                {
                    int s = n % 10;
                    sum += s;
                    n = n / 10;
                }
                return sum;
            }
            Console.Write("Nhap so ngau nhien tu ban phim= "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong cac chu so n= {TongChuSo(n)}");
            Console.WriteLine();
        }
        static void Bai09()
        {
            static int TimMax(int[] a)
            {
                int max = a[0];
                for (int k = 0; k < a.Length; k++)
                {
                    if (a[k] > max)
                        max = a[k];
                }
                return max;
            }

            int i = 0, S = 0, y = 0; int ans = 0;

            Console.Write("Nhap so phan tu: "); int N = int.Parse(Console.ReadLine()); int[] Arr = new int[12];

            int temp_ans = N;
            
            Console.Clear();

            while (N != 0)
            {
                S = N % 10;
                N /= 10;
                Arr[i] = S;
                i++;
            }

            Console.WriteLine("Mang vua nap: ");
            for(i = 0; i < Arr.Length;i++)
            {
                Console.Write($"{Arr[i]} ");                
            }
            Console.WriteLine();
            for (i = 0; i < Arr.Length; i++)
            {
                ans = TimMax(Arr);
            }
            Console.WriteLine("Max digit of {0} = {1}", temp_ans, ans);

        }
        static void Bai10()
        {
            Console.Write("Nhap n= "); int n = int.Parse(Console.ReadLine());
            if (LaNguyenTo(n) == true)
                Console.WriteLine("{0} la so nguyen to!", n);
            else
                Console.WriteLine("{0} khong la so nguyen to!", n);
            static bool LaNguyenTo(int n)
            {
                if (n < 2)
                {
                    return false;
                }

                int squareRoot = (int)Math.Sqrt(n);
                int i;
                for (i = 2; i <= squareRoot; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Bai11() 
        {
            static void tinhFibbonaci(int x)
            {
                int f0 = 0; 
                int f1 = 1;
                int fn = 1;
                int i = 0;
                while (i <= x)
                {
                    f0 = f1; 
                    f1 = fn;
                    fn = f0 + f1;
                    i++;
                    Console.Write("{0} ", fn);
                }               
            }
            Console.Write("Nhap so N: "); 
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Cac so Fibbonaci tu 2 toi {0} la: ", N);
            tinhFibbonaci(N);
        }
        static void Bai12()
        {
            Console.Write("Nhap co so a= "); double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu n= "); int n = int.Parse(Console.ReadLine());
            static double HamMu(double a, int n)
            {
                return Math.Pow(a, n);
            }
            Console.WriteLine($"Luy thua cua co so {a} va so mu {n} la {HamMu(a, n)}");
        }
        static void Bai13()
        {
            static void ResetAllVariables(ref int n, ref int code, ref int soluong)
            {
                n = 0; code = 0; soluong = 0;
            }
            static void InputPurchasedProducts(ref int code, ref int soluong)
            {
                Console.Write("     code : ");
                code = int.Parse(Console.ReadLine());
                Console.Write(" So luong : ");
                soluong = int.Parse(Console.ReadLine());
            }
            static void PrintInvoice(int i, int code, int soluong, ref double tong)
            {
                string name = "";
                 double price = 0;
                 switch(code)
                {
                    case 1: { name = "Cochorro Quente"; price = 4; break; }
                    case 2: { name = "X-Salada"; price = 4.5 ; break; }
                    case 3: { name = "X-Bacon"; price = 5; break; }
                    case 4: { name = "Torrada simples "; price = 2; break; }
                    case 5: { name = "Refrigerante"; price = 1; break; }
                }
                Console.WriteLine("                {0, 10} {1, 10} {2, 20} {3, 10} {4, 10} {5, 10}", i, code, name, soluong, price, soluong*price);
                tong = tong + soluong * price;
            }
            int code = 0, n=0, soluong=0 ;
            int chon = 1;
            
            while (chon == 1)
            {
                //Thiết lập giá trị các biến về trạng thái ban đầu
                ResetAllVariables(ref n, ref code, ref soluong);
                //Nhập số loại sản phẩm
                Console.Write("The number of products: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("  Hoa don ");
                double tong = 0;
                //Tính và in hóa đơn
                Console.WriteLine("                 {0, 10} {1, 10} {2, 15} {3, 10} {4, 10} {4, 10}",
                                    "STT", "code", "Name", "Quantity", "Price", "Total");
                for (int i = 0; i < n; i++)
                {
                    //Nhập mã code và số lượng các sản phẩm đã mua
                    InputPurchasedProducts(ref code, ref soluong); 
                    PrintInvoice(i, code, soluong, ref tong);                   
                }
                Console.WriteLine("{0, 90}","Total : " + tong);
                //Nhập lựa chọn
                Console.Write(" Tiep tuc (0/1) : ");
                chon = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Thank you & Good bye!");
        }       
        static void Main(string[] args)
        {
            Bai01();
            //Bai02();
            //Bai03(); 
            //Bai04();
            //Bai05();
            //Bai06();
            //Bai07();
            //Bai08();
            //Bai09(); 
            //Bai10();
            //Bai11(); 
            //Bai12();
            //Bai13();
        }
    }
}  